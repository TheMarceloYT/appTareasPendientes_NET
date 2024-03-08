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
    /// Lógica de interacción para CrearTarea.xaml
    /// </summary>
    public partial class CrearTarea : UserControl
    {
        //uso global de categoria
        CategoriasBLL cBLL;

        //uso global de tarea
        TareasBLL tBLL;

        //inicio los valores iniciales
        public void iniciarValores()
        {
            //fecha de hoy y estado de la tarea
            txtFechaCreacion.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtEstado.Text = "Pendiente";
            //listar categorias
            cBLL = new CategoriasBLL();
            cmbCategoria.ItemsSource = cBLL.ListarCategorias();
        }

        //limpiar txt boxs
        private void Limpiar()
        {
            txtTitulo.Text = String.Empty;
            txtCuerpo.Text = String.Empty;
            dpFechaVencimiento.SelectedDate = null;
            cmbCategoria.SelectedItem = null;
        }

        //constructor
        public CrearTarea()
        {
            InitializeComponent();
            iniciarValores();
        }

        //cancelar y limpiar
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
            iniciarValores();
        }

        //agregar tarea nueva
        private void btnAgregarTarea_Click(object sender, RoutedEventArgs e)
        {
            //obtener datos 
            string titulo = txtTitulo.Text.Trim();
            string cuerpo = txtCuerpo.Text.Trim();
            DateTime fecha = DateTime.Parse(txtFechaCreacion.Text);
            DateTime? fechaVencimiento = dpFechaVencimiento.SelectedDate;
            string estado = txtEstado.Text.Trim();
            string categoriaTarea = "";

            //validar datos
            List<string> errores = new List<string>();

            if (titulo == String.Empty)
            {
                errores.Add("- Ingrese el TITULO de la tarea");
            }
            if (cuerpo == String.Empty)
            {
                errores.Add("- Ingrese el CUERPO de la tarea");
            }
            //hay categoria seleccionada?
            if (cmbCategoria.SelectedItem == null)
            {
                errores.Add("- Seleccione la CATEGORIA de la tarea");
            }
            //si, obtengo la categoria de la tarea
            else
            {
                categoriaTarea = cmbCategoria.SelectedItem.ToString().Trim();
            }
            if (fechaVencimiento < DateTime.Today)
            {
                errores.Add("- La fecha de vencimiento no puede ser menor a HOY");
            }
            //errores?
            if (errores.Count == 0)
            {
                //tareaBLL
                tBLL = new TareasBLL();

                //no hay errores, la tarea ya existe?
                if (tBLL.getTarea(titulo) == null)
                {
                    //no existe, todo OK
                    tBLL.AgregarTarea(titulo, cuerpo, fecha, fechaVencimiento, estado, categoriaTarea);

                    MessageBox.Show("Tarea ("+titulo+") agregada con éxito", "Nueva tarea", MessageBoxButton.OK, MessageBoxImage.Information);
                    Limpiar();
                    iniciarValores();
                }
                //error, la tarea existe
                else
                {
                    MessageBox.Show("La tarea ("+titulo+") YA EXISTE", "Error al agregar tarea", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            //hay errores
            else
            {
                string msgErrores = string.Join("\n", errores);

                MessageBox.Show(msgErrores, "Errores", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
