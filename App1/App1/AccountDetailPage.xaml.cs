using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountDetailPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public AccountDetailPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Transaction 1",
                "Transaction 2",
                "Transaction 3",
                "Transaction 4",
                "Transaction 5"
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Txn Tapped", "A txn was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
