using FinancasApp.Views;

namespace FinancasApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new TransactionList());
	}
}
