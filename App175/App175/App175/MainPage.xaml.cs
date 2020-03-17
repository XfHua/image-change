using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App175
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

	public class IconView : View
	{
		#region ForegroundProperty

		public static readonly BindableProperty ForegroundProperty = BindableProperty.Create(nameof(Foreground), typeof(Color), typeof(IconView), default(Color));

		public Color Foreground
		{
			get
			{
				return (Color)GetValue(ForegroundProperty);
			}
			set
			{
				SetValue(ForegroundProperty, value);
			}
		}

		#endregion

		#region SourceProperty

		public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(string), typeof(IconView), default(string));

		public string Source
		{
			get
			{
				return (string)GetValue(SourceProperty);
			}
			set
			{
				SetValue(SourceProperty, value);
			}
		}

		#endregion
	}
}
