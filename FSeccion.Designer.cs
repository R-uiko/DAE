namespace WinFormsApp2
{
    partial class FSeccion
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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            button1Enviar = new Button();
            labelSeccion = new Label();
            textBox1 = new TextBox();
            labelid = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1Enviar);
            panel1.Controls.Add(labelSeccion);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelid);
            panel1.Location = new Point(247, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 374);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "\"UNICA\"", "\"A\"", "\"B\"" });
            comboBox1.Location = new Point(117, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Elegir";
            // 
            // button1Enviar
            // 
            button1Enviar.Location = new Point(117, 268);
            button1Enviar.Name = "button1Enviar";
            button1Enviar.Size = new Size(75, 23);
            button1Enviar.TabIndex = 4;
            button1Enviar.Text = "Enviar";
            button1Enviar.UseVisualStyleBackColor = true;
            // 
            // labelSeccion
            // 
            labelSeccion.AutoSize = true;
            labelSeccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeccion.Location = new Point(52, 148);
            labelSeccion.Name = "labelSeccion";
            labelSeccion.Size = new Size(54, 17);
            labelSeccion.TabIndex = 2;
            labelSeccion.Text = "Sección";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelid.Location = new Point(39, 65);
            labelid.Name = "labelid";
            labelid.Size = new Size(72, 17);
            labelid.TabIndex = 0;
            labelid.Text = "ID Sección";
            // 
            // FSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FSeccion";
            Text = "FSeccion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Button button1Enviar;
        private Label labelSeccion;
        private TextBox textBox1;
        private Label labelid;
    }
}