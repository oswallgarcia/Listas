namespace ListasForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.izquierda = new System.Windows.Forms.ListBox();
            this.derecha = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button14 = new System.Windows.Forms.Button();
            this.ruta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 446);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar elementos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Vaciar lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Visualiza texto item activo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(264, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Eliminar ítem";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Insertar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(264, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Cuenta registros";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(264, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "Muestra todos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(490, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 517);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // izquierda
            // 
            this.izquierda.FormattingEnabled = true;
            this.izquierda.Location = new System.Drawing.Point(12, 37);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(573, 303);
            this.izquierda.TabIndex = 11;
            // 
            // derecha
            // 
            this.derecha.AllowDrop = true;
            this.derecha.FormattingEnabled = true;
            this.derecha.Location = new System.Drawing.Point(801, 37);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(569, 303);
            this.derecha.TabIndex = 12;
            this.derecha.DragDrop += new System.Windows.Forms.DragEventHandler(this.derecha_DragDrop);
            this.derecha.DragEnter += new System.Windows.Forms.DragEventHandler(this.derecha_DragEnter);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(591, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 30);
            this.button8.TabIndex = 13;
            this.button8.Text = "> pasa un item";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(653, 85);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 30);
            this.button9.TabIndex = 14;
            this.button9.Text = "< pasa un item ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(591, 249);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 30);
            this.button10.TabIndex = 15;
            this.button10.Text = ">> pasar todos derecha";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(653, 310);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(142, 30);
            this.button11.TabIndex = 16;
            this.button11.Text = "<< pasar todos izquierda";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 348);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(156, 30);
            this.button12.TabIndex = 17;
            this.button12.Text = "limpiar lista";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1092, 348);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(156, 30);
            this.button13.TabIndex = 18;
            this.button13.Text = "limpiar lista";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(466, 348);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(119, 30);
            this.button14.TabIndex = 19;
            this.button14.Text = "Abre archivo";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // ruta
            // 
            this.ruta.AutoSize = true;
            this.ruta.Location = new System.Drawing.Point(803, 15);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(35, 13);
            this.ruta.TabIndex = 20;
            this.ruta.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 610);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox izquierda;
        private System.Windows.Forms.ListBox derecha;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label ruta;
    }
}

