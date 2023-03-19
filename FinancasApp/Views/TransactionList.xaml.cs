namespace FinancasApp.Views;

public partial class TransactionList : ContentPage
{
	public TransactionList()
	{
		InitializeComponent();
	}

	private void OnButtonCliked_TransactionAdd(object sender, EventArgs args)
	{
		App.Current.MainPage = new TransactionAdd();
	}
}