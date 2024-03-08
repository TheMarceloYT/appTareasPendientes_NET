using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class TareasBLL
    {
        //llamamos a la base de datos
        TareasPendientesEntities DB = new TareasPendientesEntities();

        //agregar tarea
        public void AgregarTarea(string titulo, string cuerpo, DateTime fechaCreacion, DateTime? fechaVencimiento, string estado, string categoria)
        {
            if (getTarea(titulo) == null)
            {
                //usar CategoriaBLL
                CategoriasBLL cBLL = new CategoriasBLL();

                //llamar a la tabla
                Tarea t = new Tarea();
                t.Titulo = titulo;
                t.Cuerpo = cuerpo;
                t.FechaCreacion = fechaCreacion;
                t.FechaVencimiento = fechaVencimiento;
                t.Estado = estado;
                t.IdCategoria = setIdCategoria(cBLL.getCategoria(categoria));

                DB.Tarea.Add(t);

                //guardar cambios
                DB.SaveChanges();
            }
        }

        //eliminar tarea
        public void EliminarTarea(string titulo)
        {
            //existe la tarea?
            if (getTarea(titulo) != null)
            {
                Tarea t = getTarea(titulo);

                //eliminarla
                DB.Tarea.Remove(t);

                //guardar cambios
                DB.SaveChanges();
            }
        }

        //modificar tarea
        public void ModificarTarea(string TituloFirst, string titulo, string cuerpo, DateTime? fechaVencimiento, string categoriaTarea)
        {
            //busco la tarea a modificar
            Tarea tarea = DB.Tarea.Where(t => t.Titulo == TituloFirst).FirstOrDefault();

            //uso la ayude de CategoriasBLL
            CategoriasBLL cBLL = new CategoriasBLL();

            //modifico los campos modificables
            tarea.Titulo = titulo;
            tarea.Cuerpo = cuerpo;
            tarea.FechaVencimiento = fechaVencimiento;
            tarea.IdCategoria = setIdCategoria(cBLL.getCategoria(categoriaTarea));

            //guardar cambios
            DB.SaveChanges();
        }

        //actualizar estado
        public void modificarEstado(string titulo)
        {
            Tarea tarea = DB.Tarea.Where(t => t.Titulo == titulo).FirstOrDefault();
            tarea.Estado = "Completada";

            //guardar cambios
            DB.SaveChanges();
        }

        //listas tareas
        public List<Tarea> listarTareas()
        {
            return DB.Tarea.ToList();
        }

        //listar tareas por categoria
        public List<Tarea> ListarTareasPorCategoria(int categoria)
        {
            return DB.Tarea.Where(t => t.IdCategoria == categoria).ToList();
        }

        //procesos get
        public Tarea getTarea(string titulo)
        {
            return DB.Tarea.Where(t => t.Titulo == titulo).FirstOrDefault();
        }

        //set el idCategoria de la tarea
        public int setIdCategoria(Categoria cat)
        {
            return cat.Id;
        }

        //get tareas según estado
        public List<Tarea> getTareasPendientes()
        {
            return DB.Tarea.Where(t => t.Estado == "Pendiente").ToList();
        }
    }
}
