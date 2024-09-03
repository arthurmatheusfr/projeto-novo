using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace charles
{
    public partial class ClientePage : ContentPage
    {
        public ObservableCollection<string> Clientes { get; set; }

        public ClientePage()
        {
            InitializeComponent();

            Clientes = new ObservableCollection<string>
            {
                "Cliente 1",
                "Cliente 2",
                // ... outros clientes
            };

            listaClientes.ItemsSource = Clientes;
        }

        private void AdicionarCliente_Clicked(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo cliente à lista
            Clientes.Add("Novo Cliente");
        }
    }
}
