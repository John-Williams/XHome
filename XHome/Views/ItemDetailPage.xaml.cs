using System.ComponentModel;
using Xamarin.Forms;
using XHome.ViewModels;

namespace XHome.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}