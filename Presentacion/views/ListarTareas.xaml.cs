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
using Negocio;

namespace Presentacion.views
{
    /// <summary>
    /// Lógica de interacción para ListarTareas.xaml
    /// </summary>
    public partial class ListarTareas : UserControl
    {
        //uso global de las tareas
        TareasBLL tBLL;

        //refrescar lista de tareas
        private void setLista()
        {
            //instancia de tareas
            tBLL = new TareasBLL();

            //instancia de categorias
            CategoriasBLL cBLL = new CategoriasBLL();

            //relleno el datagrid con las tareas
            dgTareas.ItemsSource = tBLL.listarTareas();

            //relleno el combo box con las categorias
            cmbCategorias.ItemsSource = cBLL.ListarCategorias();
        }

        //constructor
        public ListarTareas()
        {
            InitializeComponent();
            setLista();
        }

        //filtro
        private void lstCategorias_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //instancia de tareas
            tBLL = new TareasBLL();

            //usar metodos para categorias
            CategoriasBLL cBLL = new CategoriasBLL();

            string categoriaNombre = cmbCategorias.SelectedItem.ToString();

            //uso las 2 clases BLL, buscandi el ID de la categoria para listarla
            int idCategoria = tBLL.setIdCategoria(cBLL.getCategoria(categoriaNombre));

            //le paso el id de la categoria para que me devuelva solo las tareas con esa id
            dgTareas.ItemsSource = tBLL.ListarTareasPorCategoria(idCategoria);
        }
    }
}
