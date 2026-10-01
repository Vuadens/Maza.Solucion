using System;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarPromos_Click(object sender, EventArgs e)
        {
            var ventanaConsulta = Program.ServiceProvider!.GetRequiredService<ConsultarPromoEstado>();
            ventanaConsulta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Este método está vinculado actualmente al botón "Expirar promocion" en el Designer
            var ventanaExpirar = Program.ServiceProvider!.GetRequiredService<ExpirarPromo>();
            ventanaExpirar.ShowDialog();
        }

        private void btnCrearPromo_Click(object sender, EventArgs e)
        {
            // Este método será para el botón "Crear nueva promo"
            var ventanaAgregar = Program.ServiceProvider!.GetRequiredService<AgregarPromo>();
            ventanaAgregar.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
