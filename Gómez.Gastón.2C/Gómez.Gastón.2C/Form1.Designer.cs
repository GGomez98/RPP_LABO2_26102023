﻿using Entidades;

namespace Gómez.Gastón._2C
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstVehiculos = new ListBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            pcbFabrica = new PictureBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(4, 4);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(595, 499);
            lstVehiculos.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(629, 24);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(210, 32);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de vehiculo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Automovil", "Moto", "Camioneta" });
            cmbTipo.Location = new Point(609, 64);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(247, 23);
            cmbTipo.TabIndex = 2;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = (Image)resources.GetObject("pcbFabrica.Image");
            pcbFabrica.Location = new Point(642, 118);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(197, 195);
            pcbFabrica.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFabrica.TabIndex = 3;
            pcbFabrica.TabStop = false;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(611, 338);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(255, 76);
            btnFabricar.TabIndex = 4;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(616, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(250, 74);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_CLick;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 512);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(pcbFabrica);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lstVehiculos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmView";
            Text = "Fabrica de Vehiculos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private PictureBox pcbFabrica;
        private Button btnFabricar;
        private Button btnEliminar;
        private Fabrica fabrica;
    }
}