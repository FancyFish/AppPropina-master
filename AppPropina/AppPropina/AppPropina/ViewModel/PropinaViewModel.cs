
namespace AppPropina.ViewModel
{


    using System;
    using Model;
    using Xamarin.Forms;

    public class PropinaViewModel
    {
        #region Propiedades
        public Propina PropinaModel { get; set; }
        public Command CalcularCommant { get; set; }

        #endregion
        #region Constructor

        public PropinaViewModel()
        {
            PropinaModel = new Propina();
            CalcularCommant = new Command(Calcular);
        }


        #endregion
        private void Calcular(object obj)
        {
            PropinaModel.Propi = PropinaModel.TotalPropina / PropinaModel.Personas;
            PropinaModel.PersonasTotal = PropinaModel.Total / PropinaModel.Personas;
            PropinaModel.TotalPropina = (PropinaModel.TotalPropina * PropinaModel.PorcentajePropina) / 100;
            PropinaModel.Neto = PropinaModel.Total + PropinaModel.TotalPropina;

         

        }

    }
}
