using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class Account
    {

        public Account(String name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    public class AccountTypeGroup : List<Account>
    {
        public string Title { get; set; }
        private AccountTypeGroup(string title)
        {
            Title = title;
        }

        public static IList<AccountTypeGroup> All { private set; get; }

        static AccountTypeGroup()
        {
            List<AccountTypeGroup> Groups = new List<AccountTypeGroup> {
                new AccountTypeGroup ("My Savings"){
                    new Account("Savings 1"),
                    new Account("Very very very very very very very very very very very very very very very very very very very very very very very very very very long Savings 2")
                },
                new AccountTypeGroup ("My Mortgages"){
                    new Account("Mortgage 1"),
                    new Account("Mortgage 2")
                }
            };
            All = Groups;
        }
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AccountsView.ItemsSource = AccountTypeGroup.All;

        }

        async void OnAccountSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountDetailPage());
        }
    }
}
