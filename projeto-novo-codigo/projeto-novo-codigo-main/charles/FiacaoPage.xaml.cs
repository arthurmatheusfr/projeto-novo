using Microsoft.Maui.Controls;

namespace charles
{
    public partial class FiacaoPage : ContentPage
    {
        public FiacaoPage()
        {
            InitializeComponent();
        }

        private void IniciarFiacao_Clicked(object sender, EventArgs e)
        {
            // Lógica para iniciar a fiação
            string tipoFibra = entryTipoFibra.Text;
            string ajustarParametros = entryAjustarParametros.Text;
            bool fiacaoManual = chkFiaçaoManual.IsChecked;

            // Aqui você implementaria a lógica específica para iniciar a fiação
            // com base nos valores coletados dos campos
            DisplayAlert("Iniciar Fiação", $"Tipo de fibra: {tipoFibra}\nAjustar parâmetros: {ajustarParametros}\nFiação manual: {fiacaoManual}", "OK");
        }

        private void Voltar_Clicked(object sender, EventArgs e)
        {
         Application.Current.MainPage = new MainPage();
        }
    }
}
