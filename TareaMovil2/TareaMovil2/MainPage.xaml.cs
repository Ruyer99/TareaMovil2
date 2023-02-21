using TareaMovil2.Models;
using TareaMovil2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TareaMovil2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btnsuma = Numero1 + Numero2;
            var funciones = new Models.CodigoMate
            {
                numero1 = Btnsuma.ToString(),

            };
            var pagina = new Views.PageResultado();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btnresta = Numero1 - Numero2;
            var funciones = new Models.CodigoMate
            {
                numero1 = Btnresta.ToString(),

            };
            var pagina = new Views.PageResultado();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btndivision = Numero1 / Numero2;
            var funciones = new Models.CodigoMate
            {
                numero1 = Btndivision.ToString(),

            };
            var pagina = new Views.PageResultado();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            var Numero1 = double.Parse(numero1.Text);
            var Numero2 = double.Parse(numero2.Text);
            var Btnmultiplicacion = Numero1 * Numero2;
            var funciones = new Models.CodigoMate
            {
                numero1 = Btnmultiplicacion.ToString(),

            };
            var pagina = new Views.PageResultado();
            pagina.BindingContext = funciones;
            await Navigation.PushAsync(pagina);
        }
    }
}
