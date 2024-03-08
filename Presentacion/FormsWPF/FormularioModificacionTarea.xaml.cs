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
using System.Windows.Shapes;
using Negocio;
using Datos;

namespace Presentacion.FormsWPF
{
    /// <summary>
    /// Lógica de interacción para FormularioModificacionTarea.xaml
    /// </summary>
    public partial class FormularioModificacionTarea : Window
    {
        TareasBLL tBLL;
        CategoriasBLL cBLL;
        string TituloFirst = "";

        public void iniciarValores(string titulo)
        {
            tBLL = new TareasBLL();

            cBLL = new CategoriasBLL();

            Tarea tarea = tBLL.getTarea(titulo);

            //lleno formulario
            txtTitulo.Text = tarea.Titulo;
            TituloFirst = tarea.Titulo;
            txtCuerpo.Text = tarea.Cuerpo;
            txtFechaCreacion.Text = tarea.FechaCreacion.ToString();
            dpFechaVencimiento.SelectedDate = tarea.FechaVencimiento;
            txtEstado.Text = tarea.Estado;

            //llenar combo box
            cmbCategoria.ItemsSource = cBLL.ListarCategorias();

            Categoria cat = cBLL.getCategoria(cBLL.getNombreCategoria(tarea.IdCategoria));
            cmbCategoria.SelectedItem = cat;
        }

        public FormularioModificacionTarea(string titulo)
        {
            InitializeComponent();
            iniciarValores(titulo);
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAgregarTarea_Click(object sender, RoutedEventArgs e)
        {
            tBLL = new TareasBLL();

            //obtener datos 
            string titulo = txtTitulo.Text.Trim();
            string cuerpo = txtCuerpo.Text.Trim();
            DateTime? fechaVencimiento = dpFechaVencimiento.SelectedDate;
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
            if (cmbCategoria.SelectedItem == null)
            {
                errores.Add("- Seleccione la CATEGORIA de la tarea");
            }
            //obtener categoria de la tarea
            else
            {
                categoriaTarea = cmbCategoria.SelectedItem.ToString().Trim();
            }
            if (fechaVencimiento < DateTime.Today)
            {
                errores.Add("- La fecha de vencimiento no puede ser menor a HOY");
            }
            //modificar?
            if (errores.Count() == 0)
            {
                //modificar
                tBLL.ModificarTarea(TituloFirst, titulo, cuerpo, fechaVencimiento, categoriaTarea);

                MessageBox.Show("Tarea modificada con éxito", "Modificacion de tarea", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            //Hay errores
            else
            {
                string msgError = string.Join("\n", errores);
                MessageBox.Show(msgError, "Errores", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
