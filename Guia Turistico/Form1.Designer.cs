namespace Guia_Turistico
{
    partial class GuiaTuristico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guiaTuristicoDataSet = new Guia_Turistico.GuiaTuristicoDataSet();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cIUDADTableAdapter = new Guia_Turistico.GuiaTuristicoDataSetTableAdapters.CIUDADTableAdapter();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonAgregarCiudad = new System.Windows.Forms.Button();
            this.labelCoordenadas = new System.Windows.Forms.Label();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.numericUpDownDistancia = new System.Windows.Forms.NumericUpDown();
            this.buttonAgregarCamino = new System.Windows.Forms.Button();
            this.caminoTableAdapter = new Guia_Turistico.GuiaTuristicoDataSetTableAdapters.CAMINOTableAdapter();
            this.comboBoxOrigenRuta = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDestinoRuta = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonObtenerRuta = new System.Windows.Forms.Button();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.comboBoxMetodo = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEliminarCiudad = new System.Windows.Forms.Button();
            this.comboBoxCaminos = new System.Windows.Forms.ComboBox();
            this.buttonEliminarCamino = new System.Windows.Forms.Button();
            this.guiaTuristicoDataSet1 = new Guia_Turistico.GuiaTuristicoDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaTuristicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaTuristicoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "GUIA TURISTICO DE EL SALVADOR";
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.DataSource = this.cIUDADBindingSource;
            this.comboBoxOrigen.DisplayMember = "nombre";
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(69, 585);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrigen.TabIndex = 2;
            this.comboBoxOrigen.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource
            // 
            this.cIUDADBindingSource.DataMember = "CIUDAD";
            this.cIUDADBindingSource.DataSource = this.guiaTuristicoDataSet;
            // 
            // guiaTuristicoDataSet
            // 
            this.guiaTuristicoDataSet.DataSetName = "GuiaTuristicoDataSet";
            this.guiaTuristicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.DataSource = this.cIUDADBindingSource1;
            this.comboBoxDestino.DisplayMember = "nombre";
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(196, 585);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestino.TabIndex = 3;
            this.comboBoxDestino.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource1
            // 
            this.cIUDADBindingSource1.DataMember = "CIUDAD";
            this.cIUDADBindingSource1.DataSource = this.guiaTuristicoDataSet;
            // 
            // cIUDADTableAdapter
            // 
            this.cIUDADTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(69, 521);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // buttonAgregarCiudad
            // 
            this.buttonAgregarCiudad.Location = new System.Drawing.Point(175, 519);
            this.buttonAgregarCiudad.Name = "buttonAgregarCiudad";
            this.buttonAgregarCiudad.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarCiudad.TabIndex = 5;
            this.buttonAgregarCiudad.Text = "Agregar";
            this.buttonAgregarCiudad.UseVisualStyleBackColor = true;
            this.buttonAgregarCiudad.Click += new System.EventHandler(this.buttonAgregarCiudad_Click);
            // 
            // labelCoordenadas
            // 
            this.labelCoordenadas.AutoSize = true;
            this.labelCoordenadas.Location = new System.Drawing.Point(107, 544);
            this.labelCoordenadas.Name = "labelCoordenadas";
            this.labelCoordenadas.Size = new System.Drawing.Size(27, 13);
            this.labelCoordenadas.TabIndex = 6;
            this.labelCoordenadas.Text = "X, Y";
            // 
            // panelMapa
            // 
            this.panelMapa.BackgroundImage = global::Guia_Turistico.Properties.Resources.el_salvador_departments_blank;
            this.panelMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMapa.Location = new System.Drawing.Point(12, 64);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(771, 423);
            this.panelMapa.TabIndex = 8;
            this.panelMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMapa_Paint);
            this.panelMapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMapa_MouseClick);
            // 
            // numericUpDownDistancia
            // 
            this.numericUpDownDistancia.Location = new System.Drawing.Point(323, 586);
            this.numericUpDownDistancia.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDistancia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDistancia.Name = "numericUpDownDistancia";
            this.numericUpDownDistancia.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownDistancia.TabIndex = 9;
            this.numericUpDownDistancia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAgregarCamino
            // 
            this.buttonAgregarCamino.Location = new System.Drawing.Point(387, 583);
            this.buttonAgregarCamino.Name = "buttonAgregarCamino";
            this.buttonAgregarCamino.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarCamino.TabIndex = 10;
            this.buttonAgregarCamino.Text = "Agregar";
            this.buttonAgregarCamino.UseVisualStyleBackColor = true;
            this.buttonAgregarCamino.Click += new System.EventHandler(this.buttonAgregarCamino_Click);
            // 
            // caminoTableAdapter
            // 
            this.caminoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxOrigenRuta
            // 
            this.comboBoxOrigenRuta.DataSource = this.cIUDADBindingSource2;
            this.comboBoxOrigenRuta.DisplayMember = "nombre";
            this.comboBoxOrigenRuta.FormattingEnabled = true;
            this.comboBoxOrigenRuta.Location = new System.Drawing.Point(69, 654);
            this.comboBoxOrigenRuta.Name = "comboBoxOrigenRuta";
            this.comboBoxOrigenRuta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrigenRuta.TabIndex = 11;
            this.comboBoxOrigenRuta.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource2
            // 
            this.cIUDADBindingSource2.DataMember = "CIUDAD";
            this.cIUDADBindingSource2.DataSource = this.guiaTuristicoDataSet;
            // 
            // comboBoxDestinoRuta
            // 
            this.comboBoxDestinoRuta.DataSource = this.cIUDADBindingSource3;
            this.comboBoxDestinoRuta.DisplayMember = "nombre";
            this.comboBoxDestinoRuta.FormattingEnabled = true;
            this.comboBoxDestinoRuta.Location = new System.Drawing.Point(196, 654);
            this.comboBoxDestinoRuta.Name = "comboBoxDestinoRuta";
            this.comboBoxDestinoRuta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestinoRuta.TabIndex = 12;
            this.comboBoxDestinoRuta.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource3
            // 
            this.cIUDADBindingSource3.DataMember = "CIUDAD";
            this.cIUDADBindingSource3.DataSource = this.guiaTuristicoDataSet;
            // 
            // buttonObtenerRuta
            // 
            this.buttonObtenerRuta.Location = new System.Drawing.Point(450, 652);
            this.buttonObtenerRuta.Name = "buttonObtenerRuta";
            this.buttonObtenerRuta.Size = new System.Drawing.Size(99, 23);
            this.buttonObtenerRuta.TabIndex = 13;
            this.buttonObtenerRuta.Text = "Obtener Ruta";
            this.buttonObtenerRuta.UseVisualStyleBackColor = true;
            this.buttonObtenerRuta.Click += new System.EventHandler(this.buttonObtenerRuta_Click);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(555, 654);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.ReadOnly = true;
            this.textBoxRuta.Size = new System.Drawing.Size(189, 20);
            this.textBoxRuta.TabIndex = 14;
            // 
            // comboBoxMetodo
            // 
            this.comboBoxMetodo.FormattingEnabled = true;
            this.comboBoxMetodo.Location = new System.Drawing.Point(323, 654);
            this.comboBoxMetodo.Name = "comboBoxMetodo";
            this.comboBoxMetodo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetodo.TabIndex = 15;
            // 
            // comboBoxCiudades
            // 
            this.comboBoxCiudades.DataSource = this.cIUDADBindingSource4;
            this.comboBoxCiudades.DisplayMember = "nombre";
            this.comboBoxCiudades.FormattingEnabled = true;
            this.comboBoxCiudades.Location = new System.Drawing.Point(307, 521);
            this.comboBoxCiudades.Name = "comboBoxCiudades";
            this.comboBoxCiudades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiudades.TabIndex = 16;
            this.comboBoxCiudades.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource4
            // 
            this.cIUDADBindingSource4.DataMember = "CIUDAD";
            this.cIUDADBindingSource4.DataSource = this.guiaTuristicoDataSet;
            // 
            // buttonEliminarCiudad
            // 
            this.buttonEliminarCiudad.Location = new System.Drawing.Point(434, 519);
            this.buttonEliminarCiudad.Name = "buttonEliminarCiudad";
            this.buttonEliminarCiudad.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarCiudad.TabIndex = 17;
            this.buttonEliminarCiudad.Text = "Eliminar";
            this.buttonEliminarCiudad.UseVisualStyleBackColor = true;
            this.buttonEliminarCiudad.Click += new System.EventHandler(this.buttonEliminarCiudad_Click);
            // 
            // comboBoxCaminos
            // 
            this.comboBoxCaminos.FormattingEnabled = true;
            this.comboBoxCaminos.Location = new System.Drawing.Point(512, 585);
            this.comboBoxCaminos.Name = "comboBoxCaminos";
            this.comboBoxCaminos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCaminos.TabIndex = 18;
            // 
            // buttonEliminarCamino
            // 
            this.buttonEliminarCamino.Location = new System.Drawing.Point(639, 583);
            this.buttonEliminarCamino.Name = "buttonEliminarCamino";
            this.buttonEliminarCamino.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarCamino.TabIndex = 19;
            this.buttonEliminarCamino.Text = "Eliminar";
            this.buttonEliminarCamino.UseVisualStyleBackColor = true;
            this.buttonEliminarCamino.Click += new System.EventHandler(this.buttonEliminarCamino_Click);
            // 
            // guiaTuristicoDataSet1
            // 
            this.guiaTuristicoDataSet1.DataSetName = "GuiaTuristicoDataSet";
            this.guiaTuristicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GuiaTuristico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 712);
            this.Controls.Add(this.buttonEliminarCamino);
            this.Controls.Add(this.comboBoxCaminos);
            this.Controls.Add(this.buttonEliminarCiudad);
            this.Controls.Add(this.comboBoxCiudades);
            this.Controls.Add(this.comboBoxMetodo);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.buttonObtenerRuta);
            this.Controls.Add(this.comboBoxDestinoRuta);
            this.Controls.Add(this.comboBoxOrigenRuta);
            this.Controls.Add(this.buttonAgregarCamino);
            this.Controls.Add(this.numericUpDownDistancia);
            this.Controls.Add(this.panelMapa);
            this.Controls.Add(this.labelCoordenadas);
            this.Controls.Add(this.buttonAgregarCiudad);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.label1);
            this.Name = "GuiaTuristico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guia Turistico";
            this.Load += new System.EventHandler(this.GuiaTuristico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaTuristicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaTuristicoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private GuiaTuristicoDataSet guiaTuristicoDataSet;
        private System.Windows.Forms.BindingSource cIUDADBindingSource;
        private GuiaTuristicoDataSetTableAdapters.CIUDADTableAdapter cIUDADTableAdapter;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonAgregarCiudad;
        private System.Windows.Forms.Label labelCoordenadas;
        private System.Windows.Forms.Panel panelMapa;
        private System.Windows.Forms.BindingSource cIUDADBindingSource1;
        private System.Windows.Forms.NumericUpDown numericUpDownDistancia;
        private System.Windows.Forms.Button buttonAgregarCamino;
        private GuiaTuristicoDataSetTableAdapters.CAMINOTableAdapter caminoTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxOrigenRuta;
        private System.Windows.Forms.BindingSource cIUDADBindingSource2;
        private System.Windows.Forms.ComboBox comboBoxDestinoRuta;
        private System.Windows.Forms.BindingSource cIUDADBindingSource3;
        private System.Windows.Forms.Button buttonObtenerRuta;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.ComboBox comboBoxMetodo;
        private System.Windows.Forms.ComboBox comboBoxCiudades;
        private System.Windows.Forms.BindingSource cIUDADBindingSource4;
        private System.Windows.Forms.Button buttonEliminarCiudad;
        private System.Windows.Forms.ComboBox comboBoxCaminos;
        private System.Windows.Forms.Button buttonEliminarCamino;
        private GuiaTuristicoDataSet guiaTuristicoDataSet1;
    }
}

