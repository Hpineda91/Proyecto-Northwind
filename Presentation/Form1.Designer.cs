namespace Presentation
{
    partial class Form1
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
            button1 = new Button();
            label1 = new Label();
            btn_fecha = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ComboBoxFecha = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(274, 148);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "cambiarcolor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 152);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "Rojo";
            // 
            // btn_fecha
            // 
            btn_fecha.Location = new Point(119, 62);
            btn_fecha.Name = "btn_fecha";
            btn_fecha.Size = new Size(164, 29);
            btn_fecha.TabIndex = 2;
            btn_fecha.Text = "AgregarFecha";
            btn_fecha.UseVisualStyleBackColor = true;
            btn_fecha.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(537, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "textbox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(307, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Tag = "ComboBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 365);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 341);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(516, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Tag = "dateTimePicker1";
            // 
            // comboBox2
            // 
            ComboBoxFecha.FormattingEnabled = true;
            ComboBoxFecha.Location = new Point(404, 248);
            ComboBoxFecha.Name = "comboBox2";
            ComboBoxFecha.Size = new Size(151, 28);
            ComboBoxFecha.TabIndex = 8;
            ComboBoxFecha.Tag = "ComboBoxFecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ComboBoxFecha);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btn_fecha);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btn_fecha;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox ComboBoxFecha;
    }
}
