namespace COMPUTADORA.VISTAS.ComputadoraVista
{
    partial class ComputadoraEditarVista
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
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 165);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 27;
            label4.Text = "FECHA FABRIC";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 27);
            textBox3.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 12);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 25;
            label3.Text = "NOMBRE";
            // 
            // button2
            // 
            button2.Location = new Point(50, 220);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 27);
            textBox2.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 115);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 22;
            label2.Text = "PRECIO";
            // 
            // button1
            // 
            button1.Location = new Point(273, 220);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 27);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 56);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 19;
            label1.Text = "DESCRIPCION";
            // 
            // ComputadoraEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 295);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ComputadoraEditarVista";
            Text = "ComputadoraEditarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}