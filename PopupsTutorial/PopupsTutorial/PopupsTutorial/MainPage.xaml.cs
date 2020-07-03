using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupsTutorial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        async void OnDisplayAlertButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta", "Olhe para trás.", "OK");
        }

        async void OnDisplayAlertQuestionButtonClicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Salvar?", "Você gostaria de salvar?", "Sim", "Não");
            Console.WriteLine("Save data: " + response);
        }
        async void OnDisplayActionSheetButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Enviar para?", "Cancelar", null, "Email", "Twitter", "Facebook");
            Console.WriteLine("Action: " + action);
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
