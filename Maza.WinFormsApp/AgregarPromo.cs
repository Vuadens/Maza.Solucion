using Maza.DTOs;
using Maza.Application.Services;
namespace Maza.WinFormsApp
{
    public partial class AgregarPromo : Form
    {
        private readonly IPromocionService _promoService;

        // Constructor sin parámetros requerido por el diseñador de WinForms
        public AgregarPromo()
        {
            InitializeComponent();
            _promoService = null!;
        }

        public AgregarPromo(IPromocionService promoService)
        {
            InitializeComponent();
            _promoService = promoService;
        }

        private void AgregarPromo_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDescuento.Text, out decimal descuento))
            {
                MessageBox.Show("El descuento no es válido.");
                return;
            }

            var promoDto = new PromoDTO
            {
                Nombre = txtNombre.Text,
                FechaInicio = DateOnly.FromDateTime(dateInicio.Value),
                FechaFin = DateOnly.FromDateTime(dateFin.Value),
                Descuento = descuento
            };

            try
            {
                await _promoService.CrearPromoConDTOAsync(promoDto);
                MessageBox.Show("Promoción agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}