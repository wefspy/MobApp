using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void Program_Now(object sender, EventArgs e)
        {
            if(App.Db.GetCurProgramType() != ProgramType.None)
                await Navigation.PushAsync(new ProgramNow());
            else await DisplayAlert("Упс...", "Пожалуйста, выберите или создайте собственную программу тренировок", "ок");
        }

        private async void Create_Program(object sender, EventArgs e)
        {
            if (App.Db.GetCurProgramType() == ProgramType.None)
                await Navigation.PushAsync(new Create());
            else
            {
                var res = await DisplayAlert("Внимание", "Вы уверены, что хотите заменить существующую программу тренировок?", "Да", "Нет");
                if(res) await Navigation.PushAsync(new Create());
            }
        }
    }
}