namespace COMPUTADORA.VISTAS.ComputadoraVista
{
    partial class ComputadoraInsertarVista
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
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 27);
            textBox3.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 36);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 15;
            label3.Text = "NOMBRE";
            // 
            // button2
            // 
            button2.Location = new Point(76, 244);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 27);
            textBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 139);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 12;
            label2.Text = "PRECIO";
            // 
            // button1
            // 
            button1.Location = new Point(299, 244);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 27);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 80);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 9;
            label1.Text = "DESCRIPCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 189);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 17;
            label4.Text = "FECHA FABRIC";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // ComputadoraInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 335);
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
            Name = "ComputadoraInsertarVista";
            Text = "ComputadoraInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}