using Maza.DTOs;
namespace Maza.WinFormsApp
{
    partial class AgregarPromo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateInicio = new DateTimePicker();
            dateFin = new DateTimePicker();
            txtNombre = new TextBox();
            txtDescuento = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 113);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de fin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 140);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Descuento";
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(111, 78);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(200, 23);
            dateInicio.TabIndex = 4;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(111, 105);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(200, 23);
            dateFin.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(111, 137);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(200, 23);
            txtDescuento.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 9);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 8;
            label5.Text = "ALTA PROMOCION";
            label5.Click += label5_Click;   
            // 
            // button1
            // 
            button1.Location = new Point(236, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(141, 184);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(487, 439);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 11;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // AgregarPromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtDescuento);
            Controls.Add(txtNombre);
            Controls.Add(dateFin);
            Controls.Add(dateInicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarPromo";
            Text = "Form1";
            Load += AgregarPromo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateInicio;
        private DateTimePicker dateFin;
        private TextBox txtNombre;
        private TextBox txtDescuento;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}