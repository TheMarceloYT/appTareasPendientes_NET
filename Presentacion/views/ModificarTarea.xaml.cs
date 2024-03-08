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
    /// Lógica de interacción para ModificarTarea.xaml
    /// </summary>
    public partial class ModificarTarea : UserControl
    {
        //uso global de tareaBLL
        TareasBLL tBLL;

        //inicio los valires iniciales
        private void iniciarValores()
        {
            //instancia de tareas
            tBLL = new TareasBLL();

            //obetener todas las tareas y pasarlas el combobox de tareas
            cmbModificarTarea.ItemsSource = tBLL.listarTareas();

            //obtener tareas pendientes solamente y pasarlas el combobox de tareas pendientes
            cmbTareasEstado.ItemsSource = tBLL.getTareasPendientes();
        }

        //constructor
        public ModificarTarea()
        {
            InitializeComponent();
            iniciarValores();
        }

        //modificar tarea
        private void btnModificarTarea_Click(object sender, RoutedEventArgs e)
        {
            //hay una tarea seleccionada?
            if (cmbModificarTarea.SelectedItem != null)
            {
                //si la hay, obtento datos
                string titulo = cmbModificarTarea.SelectedItem.ToString();

                //abro nueva ventana y paso los datos
                FormsWPF.FormularioModificacionTarea fomrularioModificacion = new FormsWPF.FormularioModificacionTarea(titulo);
                fomrularioModificacion.ShowDialog();
            }
            //no hay nada seleccionado
            else
            {
                MessageBox.Show("Seleccione una tarea", "Error en modificar tarea", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //modificar estado
        private void btnModificarEstado_Click(object sender, RoutedEventArgs e)
        {
            //hay una tarea seleccionada?
            if (cmbTareasEstado.SelectedItem != null)
            {
                //si la hay, modficar estado de tarea
                tBLL = new TareasBLL();

                //obtengo data
                string titulo = cmbTareasEstado.SelectedItem.ToString();

                //modifico tarea a completada
                tBLL.modificarEstado(titulo);

                MessageBox.Show("Tarea ("+titulo+") marcada como completada con éxito", "Modificar estado de una tarea", MessageBoxButton.OK, MessageBoxImage.Information);
                iniciarValores();
            }
            //no hay nada seleccionado
            else
            {
                MessageBox.Show("Seleccione una tarea", "Error en modificar estado de una tarea", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
