namespace FinancasApp.Views;

public partial class TransactionList : ContentPage
{
	public TransactionList()
	{
		InitializeComponent();
	}

	private void OnButtonCliked_TransactionAdd(object sender, EventArgs args)
	{
		Navigation.PushModalAsync(new TransactionAdd());
	}

    private void OnButtonCliked_TransactionEdit(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new TransactionEdit());
    }
}