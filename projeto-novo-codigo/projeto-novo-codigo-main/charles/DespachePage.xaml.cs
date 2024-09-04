using Microsoft.Maui.Controls;

namespace charles
{
    public partial class DespachePage : ContentPage
    {
        public DespachePage()
        {
            InitializeComponent();
        }

        private void OnEnviarClicked(object sender, EventArgs e)
        {
            // Ação a ser executada quando o botão "Enviar" for clicado
            // Por exemplo, enviar os dados para um servidor ou processar a entrada
            DisplayAlert("Enviado", "Os dados foram enviados com sucesso", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
              Application.Current.MainPage = new MainPage();
        }
    }
}
