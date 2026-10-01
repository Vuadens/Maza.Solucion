namespace Maza.WinFormsApp
{
    partial class Home
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
            btnBuscarPromos = new Button();
            btnExpirarPromo = new Button();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBuscarPromos
            // 
            btnBuscarPromos.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPromos.Location = new Point(12, 63);
            btnBuscarPromos.Name = "btnBuscarPromos";
            btnBuscarPromos.Size = new Size(315, 46);
            btnBuscarPromos.TabIndex = 0;
            btnBuscarPromos.Text = "Buscar promociones por estado";
            btnBuscarPromos.UseVisualStyleBackColor = true;
            btnBuscarPromos.Click += btnBuscarPromos_Click;
            // 
            // btnExpirarPromo
            // 
            btnExpirarPromo.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnExpirarPromo.Location = new Point(12, 128);
            btnExpirarPromo.Name = "btnExpirarPromo";
            btnExpirarPromo.Size = new Size(315, 42);
            btnExpirarPromo.TabIndex = 1;
            btnExpirarPromo.Text = "Expirar promocion";
            btnExpirarPromo.UseVisualStyleBackColor = true;
            btnExpirarPromo.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            button1.Location = new Point(12, 185);
            button1.Name = "button1";
            button1.Size = new Size(315, 42);
            button1.TabIndex = 2;
            button1.Text = "Crear nueva promo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCrearPromo_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(288, 34);
            label2.TabIndex = 6;
            label2.Text = "Gestion de promociones";
            label2.Click += label2_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(btnExpirarPromo);
            Controls.Add(btnBuscarPromos);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarPromos;
        private Button btnExpirarPromo;
        private Button button1;
        private Label label2;
    }
}