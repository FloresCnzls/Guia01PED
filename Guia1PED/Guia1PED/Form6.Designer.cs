namespace Guia1PED
{
    partial class Form6
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtpuntofinY = new TextBox();
            txtpuntofinX = new TextBox();
            txtpuntoinicioY = new TextBox();
            txtpuntoinicioX = new TextBox();
            btnDibujar = new Button();
            areadibujo = new PictureBox();
            cmbColor = new ComboBox();
            txtEspaciado = new TextBox();
            txtCantidad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)areadibujo).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 155);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 39;
            label7.Text = "Fin Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 115);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 38;
            label6.Text = "Fin X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 74);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 37;
            label5.Text = "Inicio Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 32);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 36;
            label4.Text = "Inicio X";
            // 
            // txtpuntofinY
            // 
            txtpuntofinY.Location = new Point(339, 147);
            txtpuntofinY.Name = "txtpuntofinY";
            txtpuntofinY.Size = new Size(100, 23);
            txtpuntofinY.TabIndex = 35;
            // 
            // txtpuntofinX
            // 
            txtpuntofinX.Location = new Point(339, 107);
            txtpuntofinX.Name = "txtpuntofinX";
            txtpuntofinX.Size = new Size(100, 23);
            txtpuntofinX.TabIndex = 34;
            // 
            // txtpuntoinicioY
            // 
            txtpuntoinicioY.Location = new Point(339, 66);
            txtpuntoinicioY.Name = "txtpuntoinicioY";
            txtpuntoinicioY.Size = new Size(100, 23);
            txtpuntoinicioY.TabIndex = 33;
            // 
            // txtpuntoinicioX
            // 
            txtpuntoinicioX.Location = new Point(339, 24);
            txtpuntoinicioX.Name = "txtpuntoinicioX";
            txtpuntoinicioX.Size = new Size(100, 23);
            txtpuntoinicioX.TabIndex = 32;
            // 
            // btnDibujar
            // 
            btnDibujar.Location = new Point(505, 14);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(89, 23);
            btnDibujar.TabIndex = 31;
            btnDibujar.Text = "Dibujar Linea";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // areadibujo
            // 
            areadibujo.Location = new Point(505, 45);
            areadibujo.Name = "areadibujo";
            areadibujo.Size = new Size(275, 139);
            areadibujo.TabIndex = 30;
            areadibujo.TabStop = false;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Amarillo", "Rojo", "Azul", "Negro" });
            cmbColor.Location = new Point(105, 143);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(100, 23);
            cmbColor.TabIndex = 29;
            // 
            // txtEspaciado
            // 
            txtEspaciado.Location = new Point(105, 88);
            txtEspaciado.Name = "txtEspaciado";
            txtEspaciado.Size = new Size(100, 23);
            txtEspaciado.TabIndex = 28;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(105, 27);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 143);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 26;
            label3.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 25;
            label2.Text = "Espaciado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 24;
            label1.Text = "Cantidad";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 211);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtpuntofinY);
            Controls.Add(txtpuntofinX);
            Controls.Add(txtpuntoinicioY);
            Controls.Add(txtpuntoinicioX);
            Controls.Add(btnDibujar);
            Controls.Add(areadibujo);
            Controls.Add(cmbColor);
            Controls.Add(txtEspaciado);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)areadibujo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtpuntofinY;
        private TextBox txtpuntofinX;
        private TextBox txtpuntoinicioY;
        private TextBox txtpuntoinicioX;
        private Button btnDibujar;
        private PictureBox areadibujo;
        private ComboBox cmbColor;
        private TextBox txtEspaciado;
        private TextBox txtCantidad;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}