using AppConselhos.Model;
using AppConselhos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConselhos.View
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaConselho : ContentPage
    {
        public async void Default()
        {
            Conselho advice = await DataService.GetAdviceByNum("69");
            this.BindingContext = advice;
        }
        public PaginaConselho()
        {
            InitializeComponent();

            this.BindingContext = new Conselho();
            Default();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(ent_Num.Text))
                {
                    Conselho advices = await DataService.GetAdviceByNum(ent_Num.Text);
                    this.BindingContext = advices;
                }
                else
                {
                    Conselho advices = await DataService.GetAdviceRamdom();
                    this.BindingContext = advices;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "ok");
            }

        }
    }
}