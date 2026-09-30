namespace Maza.WinFormsApp
{
    partial class ConsultarPromoEstado
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
            dgvPromociones = new DataGridView();
            label2 = new Label();
            cmbEstado = new ComboBox();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            SuspendLayout();
            // 
            // dgvPromociones
            // 
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromociones.Location = new Point(22, 45);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.Size = new Size(452, 393);
            dgvPromociones.TabIndex = 0;
            dgvPromociones.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(288, 34);
            label2.TabIndex = 5;
            label2.Text = "Lista de promociones";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activas", "Expiradas", "" });
            cmbEstado.Location = new Point(480, 45);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(308, 23);
            cmbEstado.TabIndex = 6;
            cmbEstado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.MenuHighlight;
            btnFiltrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.Snow;
            btnFiltrar.Location = new Point(686, 84);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(102, 37);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // ConsultarPromoEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbEstado);
            Controls.Add(label2);
            Controls.Add(dgvPromociones);
            Name = "ConsultarPromoEstado";
            Text = "ConsultarPromoEstado";
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPromociones;
        private Label label2;
        private ComboBox cmbEstado;
        private Button btnFiltrar;
    }
}