namespace Maza.WinFormsApp
{
    partial class ExpirarPromo
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
            label1 = new Label();
            expirartxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            aceptarExpirarbtn = new Button();
            cancelarExpirarbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 0;
            label1.Text = "EXPIRAR PROMO";
            // 
            // expirartxt
            // 
            expirartxt.Location = new Point(48, 85);
            expirartxt.Name = "expirartxt";
            expirartxt.Size = new Size(218, 23);
            expirartxt.TabIndex = 1;
            expirartxt.TextChanged += expirartxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(254, 17);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el ID de la pormocion a expirar:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(30, 17);
            label3.TabIndex = 3;
            label3.Text = "ID :";
            // 
            // aceptarExpirarbtn
            // 
            aceptarExpirarbtn.BackColor = SystemColors.Highlight;
            aceptarExpirarbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aceptarExpirarbtn.ForeColor = SystemColors.Window;
            aceptarExpirarbtn.Location = new Point(191, 128);
            aceptarExpirarbtn.Name = "aceptarExpirarbtn";
            aceptarExpirarbtn.Size = new Size(75, 23);
            aceptarExpirarbtn.TabIndex = 4;
            aceptarExpirarbtn.Text = "Aceptar";
            aceptarExpirarbtn.UseVisualStyleBackColor = false;
            aceptarExpirarbtn.Click += aceptarExpirarbtn_Click;
            // 
            // cancelarExpirarbtn
            // 
            cancelarExpirarbtn.Location = new Point(99, 128);
            cancelarExpirarbtn.Name = "cancelarExpirarbtn";
            cancelarExpirarbtn.Size = new Size(75, 23);
            cancelarExpirarbtn.TabIndex = 5;
            cancelarExpirarbtn.Text = "Cancelar";
            cancelarExpirarbtn.UseVisualStyleBackColor = true;
            // 
            // ExpirarPromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelarExpirarbtn);
            Controls.Add(aceptarExpirarbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(expirartxt);
            Controls.Add(label1);
            Name = "ExpirarPromo";
            Text = "ExpirarPromo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox expirartxt;
        private Label label2;
        private Label label3;
        private Button aceptarExpirarbtn;
        private Button cancelarExpirarbtn;
    }
}