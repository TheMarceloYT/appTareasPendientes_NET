using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CategoriasBLL
    {
        //Creo una instancia de la base de datos
        TareasPendientesEntities DB = new TareasPendientesEntities();

        //Agregar una nueva categoria
        public void AgregarCategoria(string nombre)
        {
            if (getCategoria(nombre) == null)
            {
                //agrego la categoria 
                Categoria c = new Categoria();
                c.Nombre = nombre;

                DB.Categoria.Add(c);

                //guardo los cambios
                DB.SaveChanges();
            }
        }

        //Eliminar una categoria
        public void EliminarCategoria(string nombre)
        {
            if (getCategoria(nombre) != null)
            {
                Categoria cat = DB.Categoria.Where(c => c.Nombre == nombre).FirstOrDefault();

                DB.Categoria.Remove(cat);

                //guardo los cambios
                DB.SaveChanges();
            }
        }

        //Obtener categorias
        public Categoria getCategoria(string nombre)
        {
            Categoria cat = DB.Categoria.Where(c => c.Nombre == nombre).FirstOrDefault();

            return cat;
        }

        //get nombre categoria de la tarea
        public string getNombreCategoria(int id)
        {
            Categoria cat = DB.Categoria.Where(c => c.Id == id).FirstOrDefault();

            return cat.Nombre;
        }

        //listar categorias
        public List<Categoria> ListarCategorias()
        {
            return DB.Categoria.ToList();
        }
    }
}
