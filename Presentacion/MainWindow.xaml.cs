using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void setInicio()
        {
            UserControl inicio = new views.Inicio();

            this.vistas.Children.Clear();
            this.vistas.Children.Add(inicio);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setInicio();
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            setInicio();
        }

        private void btnAdminCategorias_Click(object sender, RoutedEventArgs e)
        {
            UserControl categorias = new views.AdministrarCategorias();

            this.vistas.Children.Clear();
            this.vistas.Children.Add(categorias);
        }

        private void btnNuevaTarea_Click(object sender, RoutedEventArgs e)
        {
            UserControl nuevaTarea = new views.CrearTarea();

            this.vistas.Children.Clear();
            this.vistas.Children.Add(nuevaTarea);

        }

        private void btnEliminarTarea_Click(object sender, RoutedEventArgs e)
        {
            UserControl borrarTareas = new views.BorrarTarea();

            this.vistas.Children.Clear();
            this.vistas.Children.Add(borrarTareas);
        }

        private void btnModificarTarea_Click(object sender, RoutedEventArgs e)
        {
            UserControl modificarTareas = new views.ModificarTarea();

            this.vistas.Children.Clear();
            this.vistas.Children.Add(modificarTareas);
        }

        private void btnListarTareas_Click(object sender, RoutedEventArgs e)
        {
            UserControl listarTareas = new views.ListarTareas();

            this.vistas.Children.Clear();
            this.vistas.Children.Add(listarTareas);
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
