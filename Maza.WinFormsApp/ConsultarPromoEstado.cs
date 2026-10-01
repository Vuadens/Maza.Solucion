using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maza.Application.Services;

namespace Maza.WinFormsApp
{
    public partial class ConsultarPromoEstado : Form
    {
        private readonly IPromocionService _promoService;

        // Constructor sin parámetros para el diseñador
        public ConsultarPromoEstado()
        {
            InitializeComponent();
            _promoService = null!;
        }

        public ConsultarPromoEstado(IPromocionService promoService)
        {
            InitializeComponent();
            _promoService = promoService;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un estado.");
                return;
            }

            string estado = cmbEstado.SelectedItem.ToString() ?? "";
            
            try
            {
                var promociones = await _promoService.PromosXestadoAsync(estado);
                dgvPromociones.DataSource = promociones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
