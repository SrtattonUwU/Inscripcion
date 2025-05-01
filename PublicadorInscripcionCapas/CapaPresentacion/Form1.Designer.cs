namespace CapaPresentacion
{
    partial class Inscripciones
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
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtIdentification = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEnviar = new Button();
            cbCarrera = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(191, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(159, 23);
            txtName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(191, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(159, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtIdentification
            // 
            txtIdentification.Location = new Point(191, 152);
            txtIdentification.Name = "txtIdentification";
            txtIdentification.Size = new Size(159, 23);
            txtIdentification.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 56);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Digite su nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 107);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Digite su apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 155);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Nro de cedula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 202);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 7;
            label4.Text = "Carrera de interes";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(102, 254);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(169, 23);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar Informacion";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // cbCarrera
            // 
            cbCarrera.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCarrera.FormattingEnabled = true;
            cbCarrera.Items.AddRange(new object[] { "Ingenieria Informatica", "Medicina Veterinaria", "Recursos Humanos", "Ingenieria Industrial" });
            cbCarrera.Location = new Point(191, 199);
            cbCarrera.Name = "cbCarrera";
            cbCarrera.Size = new Size(159, 23);
            cbCarrera.TabIndex = 9;
            // 
            // Inscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 323);
            Controls.Add(cbCarrera);
            Controls.Add(btnEnviar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdentification);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inscripciones";
            Text = "Inscripciones";
            Load += Inscripciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtIdentification;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEnviar;
        private ComboBox cbCarrera;
    }
}
