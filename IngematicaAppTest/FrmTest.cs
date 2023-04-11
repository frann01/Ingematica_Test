using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngematicaAppTest.Model;
using IngematicaAppTest.Service;

namespace IngematicaAppTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            InitializeCombos();
        }


        private void InitializeCombos()
        {
            InitializeComboTipoTransporte();

            InitializeCoboLocalidad();

            InitializeComboRuta();
        }

        private void InitializeComboTipoTransporte()
        {
            List<TipoTransporteModel> tipoTransporteList = new List<TipoTransporteModel>();
            TipoTransporteService tipoTransporteService = new TipoTransporteService();
            tipoTransporteList = tipoTransporteService.GetList();

            var bindingSourceTipoTransporte = new BindingSource();
            bindingSourceTipoTransporte.DataSource = tipoTransporteList;

            cbTipoTransporte.DataSource = bindingSourceTipoTransporte;
            cbTipoTransporte.DisplayMember = "Nombre";
            cbTipoTransporte.ValueMember = "Id";
        }

        private void InitializeCoboLocalidad()
        {
            List<LocalidadModel> localidadList = new List<LocalidadModel>();
            LocalidadService localidadService = new LocalidadService();
            localidadList = localidadService.GetList();

            var bindingSourceLocalidad = new BindingSource();
            bindingSourceLocalidad.DataSource = localidadList;

            cbLocalidadDestino.DataSource = bindingSourceLocalidad;
            cbLocalidadDestino.DisplayMember = "Nombre";
            cbLocalidadDestino.ValueMember = "Id";
        }

        private void InitializeComboRuta()
        {
            cbTipoRuta.Items.Add("Ruta");
            cbTipoRuta.Items.Add("Autopista");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbTipoRuta.Text = "";
            cbLocalidadDestino.Text = "";
            cbTipoTransporte.Text = "";
            dtpFechaInicial.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (validarCombos())
            {
                ResultadoModel resultado = CalculoService.Calcular((LocalidadModel)cbLocalidadDestino.SelectedItem,
                (TipoTransporteModel)cbTipoTransporte.SelectedItem,
                cbTipoRuta.Text,
                dtpFechaInicial.Value);

                txtDiasDemora.Text = resultado.diasDemora.ToString();
                txtFechaLlegada.Text = resultado.fechaLlegada.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos!", "Error");
            }
            
        }

        private bool validarCombos()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(cbTipoRuta.Text) || 
                string.IsNullOrEmpty(cbLocalidadDestino.Text) || 
                string.IsNullOrEmpty(cbTipoTransporte.Text))
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
