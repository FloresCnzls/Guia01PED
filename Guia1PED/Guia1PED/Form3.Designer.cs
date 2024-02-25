namespace Guia1PED
{
    partial class Form3
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
            btnDibujar = new Button();
            areadibujo = new PictureBox();
            cmbColor = new ComboBox();
            txtEspaciado = new TextBox();
            txtCantidad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)areadibujo).BeginInit();
            SuspendLayout();
            // 
            // btnDibujar
            // 
            btnDibujar.Location = new Point(234, 22);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(89, 23);
            btnDibujar.TabIndex = 15;
            btnDibujar.Text = "Dibujar Linea";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // areadibujo
            // 
            areadibujo.Location = new Point(234, 53);
            areadibujo.Name = "areadibujo";
            areadibujo.Size = new Size(275, 139);
            areadibujo.TabIndex = 14;
            areadibujo.TabStop = false;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Amarillo", "Rojo", "Azul", "Negro" });
            cmbColor.Location = new Point(116, 146);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(100, 23);
            cmbColor.TabIndex = 13;
            // 
            // txtEspaciado
            // 
            txtEspaciado.Location = new Point(116, 91);
            txtEspaciado.Name = "txtEspaciado";
            txtEspaciado.Size = new Size(100, 23);
            txtEspaciado.TabIndex = 12;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(116, 30);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 146);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Espaciado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 8;
            label1.Text = "Cantidad";
            // 
            // button1
            // 
            button1.Location = new Point(394, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 262);
            Controls.Add(button1);
            Controls.Add(btnDibujar);
            Controls.Add(areadibujo);
            Controls.Add(cmbColor);
            Controls.Add(txtEspaciado);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)areadibujo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDibujar;
        private PictureBox areadibujo;
        private ComboBox cmbColor;
        private TextBox txtEspaciado;
        private TextBox txtCantidad;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}