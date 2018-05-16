using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropina
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnCarcular.Clicked += BtnCarcular_Clicked; 
		}

        private void BtnCarcular_Clicked(object sender, EventArgs e)
        {
            var total = decimal.Parse(entTotal.Text);
            var propina = decimal.Parse(entPropina.Text);
            var numPersona = int.Parse(entPersonas.Text);
            var totalneto = (total * propina) / 100;
            TxtTotalPropina.Detail = totalneto.ToString("C");
            TxtPropinaPersona.Detail = (totalneto / numPersona).ToString("C");
            TxtTotal.Detail = (total + totalneto).ToString("C");
            TxtTotalPersona.Detail = ((total+ totalneto)/ numPersona).ToString("C");



        }
    }
}
