using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace charles
{
    public partial class CosturaPage : ContentPage
    {
        public class ItemCostura
        {
            public int Numero { get; set; }
            public string Nome { get; set; }
        }

        public ObservableCollection<ItemCostura> Itens { get; set; }

        public CosturaPage()
        {
            InitializeComponent();

            Itens = new ObservableCollection<ItemCostura>
            {
                new ItemCostura { Numero = 1, Nome = "Bolsos" },
                new ItemCostura { Numero = 1, Nome = "Gancho frontal" },
                // ... outros itens
            };

            listaItens.ItemsSource = Itens;
        }

        private void SepararParaCriar_Clicked(object sender, EventArgs e)
        {
            // Lógica para separar os itens para criar
            // ... (ex: navegar para outra página, exibir um modal, etc.)
        }
    }
}
