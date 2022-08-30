using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListaSupermercado.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaProdutos : ContentPage
    {
        public ListaProdutos()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Novo(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new FormularioCadastro());
            }
            catch(Exception ex)
            {
                DisplayAlert("Opa!", ex.Message, "OK");
            }
        }

        private void ToolbarItem_Somar(object sender, EventArgs e)
        {

        }
    }
}