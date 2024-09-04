using Microsoft.Maui.Controls;

namespace charles
{
    public partial class CompraEstoquePage : ContentPage
    {
        public CompraEstoquePage()
        {
            InitializeComponent();
        }

        private void OnComprarAgoraClicked(object sender, EventArgs e)
        {
            // Ação a ser executada quando o botão "Comprar Agora" for clicado
            // Por exemplo, enviar os dados para um servidor ou processar a entrada
            DisplayAlert("Compra", "A compra foi realizada com sucesso", "OK");
        }

        void VoltarClicked(object sender, EventArgs e)
        {
             if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
        }
    }
}
