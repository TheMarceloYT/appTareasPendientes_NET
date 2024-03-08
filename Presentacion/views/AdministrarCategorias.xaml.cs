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
    /// Lógica de interacción para AdministrarCategorias.xaml
    /// </summary>
    public partial class AdministrarCategorias : UserControl
    {
        //limpiar txtBox
        private void Limpiar()
        {
            txtNombreCategoria.Text = String.Empty;
        }

        //declarar CategoriasBLL para uso global
        CategoriasBLL cBLL;

        //listar categorias en el list box
        public void setListBoxValues()
        {
            cBLL = new CategoriasBLL();

            lstCategorias.ItemsSource = cBLL.ListarCategorias();
        }

        //constructor
        public AdministrarCategorias()
        {
            InitializeComponent();
            setListBoxValues();
        }

        //agregar categoria
        private void btnNuevaCategoria_Click(object sender, RoutedEventArgs e)
        {
            //saber si el nombre es número
            bool catIsNumber = int.TryParse(txtNombreCategoria.Text.Trim(), out int number);

            //errores?
            if (catIsNumber == true)
            {
                MessageBox.Show("Escriba sin números el nombre de la categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtNombreCategoria.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Escriba el nombre de la categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //no hay errores
            else
            {
                //obtengo el nombre
                string categoria = txtNombreCategoria.Text.Trim();

                //instancia de para BLL
                cBLL = new CategoriasBLL();

                //la categoria existe?
                if (cBLL.getCategoria(categoria) !=  null)
                {
                    MessageBox.Show("La categoria ("+categoria+") YA EXISTE", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                //la categoria NO EXISTE, agrego la nueva categoria
                else
                {
                    cBLL.AgregarCategoria(categoria);

                    MessageBox.Show("Categoria ("+categoria+") agregada con éxito", "Agregar una categoria", MessageBoxButton.OK, MessageBoxImage.Information);
                    setListBoxValues();
                    Limpiar();
                }
            }
        }

        //eliminar categoria
        private void btnEliminarCategoria_Click(object sender, RoutedEventArgs e)
        {
            //hay una categoria seleccionada?
            if (lstCategorias.SelectedItem == null)
            {
                MessageBox.Show("Elija una categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //si hay, la elimino
            else
            {
                //instancia de para BLL
                cBLL = new CategoriasBLL();

                //obtengo la categoria seleccionada
                string categoria = lstCategorias.SelectedItem.ToString();

                //elimino categoria
                cBLL.EliminarCategoria(categoria);
                MessageBox.Show("Categoria (" + categoria + ") eliminada con éxito", "Eliminar una categoria", MessageBoxButton.OK, MessageBoxImage.Information);
                setListBoxValues();
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            setListBoxValues();
        }
    }
}
