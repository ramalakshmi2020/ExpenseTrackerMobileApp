using ExpenseMobileApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpenseMobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ExpenseManager.InitializeData();
          
        }

        protected async override void OnAppearing()
        {
            string yearMonth = $"{DateTime.Now.Month}.{DateTime.Now.Year}.First";
            //Decide what template to display based on condition
            if (ExpenseManager.IsMonthInitialised(DateTime.Now.Year, DateTime.Now.Month))
            {
               
                await Navigation.PushModalAsync(new NavigationPage(new ExpenseDisplayPage { BindingContext = yearMonth } ));
            }
            else
            {
                await Navigation.PushModalAsync(new NavigationPage(new SetBudgetPage { BindingContext = yearMonth }));
            }
        }
        
        
    }
}
