namespace charles;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
 private void DespacheClicked(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new DespachePage();
  }
 private void CompraEstoqueClicked(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new CompraEstoquePage();
  }
  private void ListaClicked(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new ListaClientesPage();
  }
  private void FiacaoClicked(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new FiacaoPage();
  }
  
}