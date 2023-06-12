using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PreparationTraining : ContentPage
	{
		private List<Exercise> exercises;
		private int numberEx;
        public PreparationTraining (List<Exercise> exercises, int numberEx)
		{
			InitializeComponent();
			this.exercises = exercises;
			this.numberEx = numberEx;
			GifcurEx.Source = exercises[numberEx].Anim;
        }
    }
}