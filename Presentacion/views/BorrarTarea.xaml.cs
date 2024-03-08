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
    /// Lógica de interacción para BorrarTarea.xaml
    /// </summary>
    public partial class BorrarTarea : UserControl
    {
        //uso global de tareasBLL
        TareasBLL tBLL;

        public void iniciarValores()
        {
            //instancia de BLL
            tBLL = new TareasBLL();

            lstTareas.ItemsSource = tBLL.listarTareas();

        }

        public BorrarTarea()
        {
            InitializeComponent();
            iniciarValores();
        }

        private void btnEliminarTarea_Click(object sender, RoutedEventArgs e)
        {
            //obtener tarea para borrar
            string tarea = "";

            //hay una tarea seleccionada?
            if (lstTareas.SelectedItem != null)
            {
                //si hay 
                tBLL = new TareasBLL();
                tarea = lstTareas.SelectedItem.ToString().Trim();

                //eliminar
                tBLL.EliminarTarea(tarea);

                MessageBox.Show("Tarea ("+tarea+") borrada con EXITO", "Eliminación de una tarea", MessageBoxButton.OK, MessageBoxImage.Information);
                iniciarValores();
            }
            //no hay nada seleccionado
            else
            {
                MessageBox.Show("Seleccione la tarea a borrar","Error en borrar una tarea", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
