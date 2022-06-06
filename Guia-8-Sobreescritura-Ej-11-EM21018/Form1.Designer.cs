
namespace Guia_8_Sobreescritura_Ej_11_EM21018
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbFigura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEquilatero = new System.Windows.Forms.RadioButton();
            this.rbEscaleno = new System.Windows.Forms.RadioButton();
            this.rbIsosceles = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCL2 = new System.Windows.Forms.TextBox();
            this.tbCL1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTL3 = new System.Windows.Forms.TextBox();
            this.tbTL2 = new System.Windows.Forms.TextBox();
            this.tbTL1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area de las figuras";
            // 
            // cbFigura
            // 
            this.cbFigura.FormattingEnabled = true;
            this.cbFigura.Items.AddRange(new object[] {
            "Cuadrado",
            "Rectangulo",
            "Triangulo"});
            this.cbFigura.Location = new System.Drawing.Point(67, 58);
            this.cbFigura.Name = "cbFigura";
            this.cbFigura.Size = new System.Drawing.Size(121, 21);
            this.cbFigura.TabIndex = 1;
            this.cbFigura.SelectedIndexChanged += new System.EventHandler(this.cbFigura_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Figura:";
            // 
            // txtArea
            // 
            this.txtArea.AutoSize = true;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(97, 250);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(41, 16);
            this.txtArea.TabIndex = 3;
            this.txtArea.Text = "Area";
            this.txtArea.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEquilatero);
            this.groupBox1.Controls.Add(this.rbEscaleno);
            this.groupBox1.Controls.Add(this.rbIsosceles);
            this.groupBox1.Location = new System.Drawing.Point(15, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de triangulo";
            this.groupBox1.Visible = false;
            // 
            // rbEquilatero
            // 
            this.rbEquilatero.AutoSize = true;
            this.rbEquilatero.Location = new System.Drawing.Point(6, 95);
            this.rbEquilatero.Name = "rbEquilatero";
            this.rbEquilatero.Size = new System.Drawing.Size(72, 17);
            this.rbEquilatero.TabIndex = 2;
            this.rbEquilatero.Text = "Equilátero";
            this.rbEquilatero.UseVisualStyleBackColor = true;
            this.rbEquilatero.CheckedChanged += new System.EventHandler(this.rbEquilatero_CheckedChanged);
            // 
            // rbEscaleno
            // 
            this.rbEscaleno.AutoSize = true;
            this.rbEscaleno.Location = new System.Drawing.Point(6, 62);
            this.rbEscaleno.Name = "rbEscaleno";
            this.rbEscaleno.Size = new System.Drawing.Size(69, 17);
            this.rbEscaleno.TabIndex = 1;
            this.rbEscaleno.Text = "Escaleno";
            this.rbEscaleno.UseVisualStyleBackColor = true;
            // 
            // rbIsosceles
            // 
            this.rbIsosceles.AutoSize = true;
            this.rbIsosceles.Checked = true;
            this.rbIsosceles.Location = new System.Drawing.Point(6, 29);
            this.rbIsosceles.Name = "rbIsosceles";
            this.rbIsosceles.Size = new System.Drawing.Size(69, 17);
            this.rbIsosceles.TabIndex = 0;
            this.rbIsosceles.TabStop = true;
            this.rbIsosceles.Text = "Isósceles";
            this.rbIsosceles.UseVisualStyleBackColor = true;
            this.rbIsosceles.CheckedChanged += new System.EventHandler(this.Isosceles_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbCL2);
            this.groupBox3.Controls.Add(this.tbCL1);
            this.groupBox3.Location = new System.Drawing.Point(159, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 112);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lados de la figura";
            this.groupBox3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingresa los lados de la figura";
            // 
            // tbCL2
            // 
            this.tbCL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCL2.Location = new System.Drawing.Point(115, 59);
            this.tbCL2.Name = "tbCL2";
            this.tbCL2.Size = new System.Drawing.Size(61, 22);
            this.tbCL2.TabIndex = 1;
            this.tbCL2.Visible = false;
            // 
            // tbCL1
            // 
            this.tbCL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCL1.Location = new System.Drawing.Point(48, 59);
            this.tbCL1.Name = "tbCL1";
            this.tbCL1.Size = new System.Drawing.Size(61, 22);
            this.tbCL1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTL3);
            this.groupBox2.Controls.Add(this.tbTL2);
            this.groupBox2.Controls.Add(this.tbTL1);
            this.groupBox2.Location = new System.Drawing.Point(190, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lados del triangulo";
            this.groupBox2.Visible = false;
            // 
            // tbTL3
            // 
            this.tbTL3.Location = new System.Drawing.Point(62, 92);
            this.tbTL3.Name = "tbTL3";
            this.tbTL3.Size = new System.Drawing.Size(70, 20);
            this.tbTL3.TabIndex = 2;
            this.tbTL3.Visible = false;
            // 
            // tbTL2
            // 
            this.tbTL2.Location = new System.Drawing.Point(62, 61);
            this.tbTL2.Name = "tbTL2";
            this.tbTL2.Size = new System.Drawing.Size(70, 20);
            this.tbTL2.TabIndex = 1;
            this.tbTL2.Visible = false;
            // 
            // tbTL1
            // 
            this.tbTL1.Location = new System.Drawing.Point(62, 29);
            this.tbTL1.Name = "tbTL1";
            this.tbTL1.Size = new System.Drawing.Size(70, 20);
            this.tbTL1.TabIndex = 0;
            this.tbTL1.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(37, 278);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingrese los lados que son\r\ndistintos en figura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "La area de la figura es:";
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(262, 281);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(72, 20);
            this.tbResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 333);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFigura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFigura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEquilatero;
        private System.Windows.Forms.RadioButton rbEscaleno;
        private System.Windows.Forms.RadioButton rbIsosceles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTL3;
        private System.Windows.Forms.TextBox tbTL2;
        private System.Windows.Forms.TextBox tbTL1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCL2;
        private System.Windows.Forms.TextBox tbCL1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

