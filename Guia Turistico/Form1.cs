using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Guia_Turistico
{
    public partial class GuiaTuristico : Form
    {
        private List<Vertice> Vertices = new List<Vertice>();
        private List<Arco> Arcos = new List<Arco>();
        private List<int> Ruta = new List<int>();
        Point coordenadas = new Point();

        public GuiaTuristico()
        {
            InitializeComponent();
        }

        private void GuiaTuristico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guiaTuristicoDataSet1.CIUDAD' table. You can move, or remove it, as needed.
            // this.cIUDADTableAdapter.Fill(this.guiaTuristicoDataSet1.CIUDAD);
            // TODO: This line of code loads data into the 'guiaTuristicoDataSet.CIUDAD' table. You can move, or remove it, as needed.
            this.cIUDADTableAdapter.Fill(this.guiaTuristicoDataSet.CIUDAD);

            textBoxRuta.Visible = false;

            comboBoxMetodo.Items.Clear();
            comboBoxMetodo.Items.Add("Dijkstra");
            comboBoxMetodo.Items.Add("Floyd");

            int cantidad = (int)this.cIUDADTableAdapter.CountQuery();
            string nombre;
            Point c = new Point();
            for (int i = 0; i < cantidad; i++)
            {
                nombre = this.cIUDADTableAdapter.GetData()[i].nombre;
                c.X = this.cIUDADTableAdapter.GetData()[i].posicion_x;
                c.Y = this.cIUDADTableAdapter.GetData()[i].posicion_y;
                Vertices.Add(new Vertice(c, nombre, i));                
            }

            cantidad = (int)this.caminoTableAdapter.CountQuery();
            int origen;
            int destino;
            int distancia;
            string sOrigen;
            string sDestino;
            for (int i = 0; i < cantidad; i++)
            {
                origen = this.caminoTableAdapter.GetData()[i].ciudad_origen;
                destino = this.caminoTableAdapter.GetData()[i].ciudad_destino;
                distancia = this.caminoTableAdapter.GetData()[i].distancia;
                Arcos.Add(new Arco(origen, destino, distancia));
                sOrigen = Vertices[origen].nombre;
                sDestino = Vertices[destino].nombre;
                comboBoxCaminos.Items.Add(sOrigen + " -> " + sDestino);
            }
        }

        private void panelMapa_MouseClick(object sender, MouseEventArgs e)
        {
            coordenadas.X = e.X;
            coordenadas.Y = e.Y;
            labelCoordenadas.Text = e.X.ToString() + ", " + e.Y.ToString();
        }

        private void panelMapa_Paint(object sender, PaintEventArgs e)
        {
            int cantidad = (int)this.cIUDADTableAdapter.CountQuery();
            for (int i = 0; i < cantidad; i++)
            {
                DibujarVertice(i, false);
            }

            cantidad = (int)this.caminoTableAdapter.CountQuery();
            for (int i = 0; i < cantidad; i++)
            {
                DibujarArco(i, false);
            }

            for (int i = 0; i < Ruta.Count - 1; i++)
            {
                DibujarVertice(Ruta[i], true);
                for (int j = 0; j < Arcos.Count; j++)
                {
                    if ((Arcos[j].origen == Ruta[i]) && (Arcos[j].destino == Ruta[i + 1]))
                        DibujarArco(j, true);
                }
            }
            if(Ruta.Count > 0)
                DibujarVertice(Ruta.Count - 1, true);
        }

        private void DibujarVertice(int vertice, bool esRuta)
        {            
            Graphics g = panelMapa.CreateGraphics();
            Vertice p = Vertices[vertice];
            SolidBrush brush;
            if (!esRuta)
                brush = new SolidBrush(Color.Blue);
            else
                brush = new SolidBrush(Color.Green);

            g.FillEllipse(brush, p.p.X - 15, p.p.Y - 15, 30, 30);
            g.DrawString(p.nombre, new Font("Verdana", 11, FontStyle.Bold), new SolidBrush(Color.DarkGreen), p.p.X - 40, p.p.Y - 30);

            g.Dispose();
        }

        private void DibujarArco(int arco, bool esRuta)
        {            
            Graphics g = panelMapa.CreateGraphics();
            Arco p = Arcos[arco];
            Vertice origen = Vertices[p.origen];
            Vertice destino = Vertices[p.destino];
            Point pOrigen;
            Point pDestino;
            Pen pen;

            //pOrigen = new Point(origen.p.X + (origen.p.X < destino.p.X ? 2 : -2) * 1, origen.p.Y);
            //pDestino = new Point(destino.p.X + (origen.p.X < destino.p.X ? -2 : 2) * 1, destino.p.Y);
            pOrigen = origen.p;
            pDestino = destino.p;

            if(!esRuta)
                pen = new Pen(Color.Black, 4);
            else
                pen = new Pen(Color.Red, 5);

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.ArrowAnchor;

            g.DrawString(p.distancia.ToString(), new Font("Verdana", 11, FontStyle.Bold), new SolidBrush(Color.Red), new Point((pOrigen.X + pDestino.X) / 2, (pOrigen.Y + pDestino.Y) / 2 + (pOrigen.Y < pDestino.Y ? (-30) : 15)));
            g.DrawLine(pen, origen.p, destino.p);

            g.Dispose();
        }        

        private void buttonAgregarCiudad_Click(object sender, EventArgs e)
        {            
            Vertices.Add(new Vertice(coordenadas, textBoxNombre.Text, Vertices.Count));
            int cantidad = (int)this.cIUDADTableAdapter.CountQuery();
            cIUDADTableAdapter.InsertQuery(cantidad, textBoxNombre.Text, coordenadas.X, coordenadas.Y);
            DibujarVertice(Vertices.Count - 1, false);
            this.cIUDADTableAdapter.Fill(this.guiaTuristicoDataSet.CIUDAD);
            MessageBox.Show("La Ciudad " + textBoxNombre.Text + " Fue Agregada");
        }        

        private void buttonAgregarCamino_Click(object sender, EventArgs e)
        {
            if (comboBoxOrigen.SelectedValue == comboBoxDestino.SelectedValue)
            {
                MessageBox.Show("No se puede agregar un camino hacia la misma ciudad");
                return;
            }
            try
            {
                int origen = Int32.Parse(comboBoxOrigen.SelectedValue.ToString());
                string sOrigen = Vertices[origen].nombre;
                int destino = Int32.Parse(comboBoxDestino.SelectedValue.ToString());
                string sDestino = Vertices[destino].nombre;
                int distancia = (int)numericUpDownDistancia.Value;
                int cantidad = (int)this.caminoTableAdapter.CountQuery();


                caminoTableAdapter.InsertQuery(cantidad, origen, destino, distancia);
                Arcos.Add(new Arco(origen, destino, distancia));
                DibujarArco(Arcos.Count - 1, false);
                comboBoxCaminos.Items.Add(sOrigen + "->" + sDestino);
            }
            catch (FormatException)
            {
                MessageBox.Show("No se especifico la distancia");
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No ha seleccionado un vertice");
                return;
            }

            MessageBox.Show("El Camino Fue Agregado");
        }

        private void buttonObtenerRuta_Click(object sender, EventArgs e)
        {
            int origen = Int32.Parse(comboBoxOrigenRuta.SelectedValue.ToString());
            int destino = Int32.Parse(comboBoxDestinoRuta.SelectedValue.ToString());
            int[,] adyacencia = new int[Vertices.Count, Vertices.Count];
            int metodo = comboBoxMetodo.SelectedIndex;
            Ruta.Clear();

            for (int i = 0; i < Vertices.Count; i++)
            {
                for (int j = 0; j < Vertices.Count; j++)
                {
                    if (i == j)
                    {
                        adyacencia[i, j] = 0;
                    }
                    else
                    {
                        if (metodo == 0)
                            adyacencia[i, j] = -1;
                        else if (metodo == 1)
                            adyacencia[i, j] = 100000;
                    }
                }
            }
            foreach (Arco arco in Arcos)
            {
                adyacencia[arco.origen, arco.destino] = arco.distancia;
            }

            if (metodo == 0)
            {
                Dijkstra dijkstra = new Dijkstra(adyacencia);
                dijkstra.ObtenerRutas(origen);
                // textBoxRuta.Text = dijkstra.Ruta(destino) + " --> " + destino.ToString();
                Ruta = dijkstra.Ruta(destino);
            }
            else if (metodo == 1)
            {
                Floyd floyd = new Floyd(Vertices, adyacencia);
                floyd.ObtenerRutas();
                // textBoxRuta.Text = floyd.Ruta(origen, destino);
                Ruta = floyd.Ruta(origen, destino);
            }
            panelMapa.Invalidate();
        }

        private void buttonEliminarCiudad_Click(object sender, EventArgs e)
        {
            int ciudad = comboBoxCiudades.SelectedIndex;
            SqlConnection connection = new SqlConnection(Guia_Turistico.Properties.Settings.Default.GuiaTuristicoConnectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            connection.Open();
            command.CommandText = "ALTER TABLE CAMINO NOCHECK CONSTRAINT ALL";
            command.ExecuteNonQuery();
            command.CommandText = "ALTER TABLE CIUDAD NOCHECK CONSTRAINT ALL";
            command.ExecuteNonQuery();

            for (int i = 0; i < Arcos.Count; i++)
            {
                if ((Arcos[i].origen == ciudad) || (Arcos[i].destino == ciudad))
                {
                    caminoTableAdapter.DeleteByCodigo(i);
                    for (int j = i; j < Arcos.Count; j++)
                    {
                        caminoTableAdapter.CodigoMinus1(j);
                    }
                    Arcos.RemoveAt(i);
                }
            }

            cIUDADTableAdapter.DeleteByCodigo(ciudad);
            for (int i = ciudad + 1; i < Vertices.Count; i++)
            {
                cIUDADTableAdapter.CodigoMinus1(i);
            }
            command.CommandText = "ALTER TABLE CAMINO WITH CHECK CHECK CONSTRAINT ALL";
            command.ExecuteNonQuery();
            command.CommandText = "ALTER TABLE CIUDAD WITH CHECK CHECK CONSTRAINT ALL";
            command.ExecuteNonQuery();
            connection.Close();

            Vertices.RemoveAt(ciudad);
            this.cIUDADTableAdapter.Fill(this.guiaTuristicoDataSet.CIUDAD);
            panelMapa.Invalidate();
        }

        private void buttonEliminarCamino_Click(object sender, EventArgs e)
        {
            int camino = comboBoxCaminos.SelectedIndex;
            SqlConnection connection = new SqlConnection(Guia_Turistico.Properties.Settings.Default.GuiaTuristicoConnectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            connection.Open();
            command.CommandText = "ALTER TABLE CAMINO NOCHECK CONSTRAINT ALL";
            command.ExecuteNonQuery();
            caminoTableAdapter.DeleteByCodigo(camino);
            for (int i = camino + 1; i < Arcos.Count; i++)
            {
                caminoTableAdapter.CodigoMinus1(i);
            }            
            command.CommandText = "ALTER TABLE CAMINO WITH CHECK CHECK CONSTRAINT ALL";
            command.ExecuteNonQuery();
            connection.Close();

            comboBoxCaminos.Items.RemoveAt(camino);
            Arcos.RemoveAt(camino);
            this.cIUDADTableAdapter.Fill(this.guiaTuristicoDataSet.CIUDAD);
            panelMapa.Invalidate();
        }        
    }
}
