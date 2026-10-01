using Maza.Application.Services;
using Maza.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maza.WinFormsApp
{
    public partial class ExpirarPromo : Form
    {
        private readonly IPromocionService _promoService;
        public ExpirarPromo(IPromocionService promoService)
        {
            InitializeComponent();
            _promoService = promoService;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void aceptarExpirarbtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(expirartxt.Text, out int id))
            {
                MessageBox.Show("El ID no es válido.");
                return;
            }

            try
            {
                await _promoService.ExpirarPromoAsync(id);
                MessageBox.Show("Promoción expirada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void expirartxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
