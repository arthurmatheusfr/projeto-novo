using Microsoft.Maui.Controls;

namespace charles
{
    public partial class RevisaoPage : ContentPage
    {
        public RevisaoPage()
        {
            InitializeComponent();
        }

        private void Desmanchar_Clicked(object sender, EventArgs e)
        {
            // Lógica para desmanchar e refazer (ex: limpar campos, voltar para uma tela anterior)
            // ...
        }

        private void EstaCorreto_Clicked(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Confirmar Alterações", "Tem certeza que deseja salvar as alterações?", "Cancelar", "Salvar");

    if (resposta)
    {
        // Salvar as alterações no banco de dados
        await App.Database.SaveItemAsync(item);
        await Navigation.PopAsync(); // Voltar para a página anterior
    }
        }
    }
}
