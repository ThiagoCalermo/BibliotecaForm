using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpbibliotecaBD
{
    internal class Libros
    {
        private int id;
        private string titulo;
        private string autor;
        private string editorial;
        private string genero;
        private int ubicación;
        private int copiasDisponibles;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public int Ubicacion
        {
            get { return ubicación; }
            set { ubicación = value; }
        }
        public int CopiasDisponibles
        {
            get { return copiasDisponibles; }
            set { copiasDisponibles = value; }
        }
        public Libros() { }
        public Libros(string pTitulo, string pAutor, string pEditorial, string pGenero, int pUbicacion, int pCopiasDisponibles)
        {
            Titulo = pTitulo;
            Autor = pAutor;
            Editorial = pEditorial;
            Genero = pGenero;
            Ubicacion = pUbicacion;
            CopiasDisponibles = pCopiasDisponibles;
        }
        public static DataTable SearchAll()
        {
            DataTable dt = new DataTable();
            string consulta = $"SELECT * FROM Libros";
            dt = BaseDatos.Search(consulta);
            return dt;
        }
        public bool New()
        {
            bool correcto = false;
            string consulta = $"INSERT INTO Libros VALUES ('{Titulo}','{Autor}','{Editorial}','{Genero}','{Ubicacion}','{CopiasDisponibles}')";
            correcto = BaseDatos.ExecuteQuery(consulta);
            return correcto;
        }
        public static bool Clear(int nro)
        {
            bool correcto = false;
            string consulta = $"DELETE FROM Libros WHERE Id = '{nro}'";
            correcto = BaseDatos.ExecuteQuery(consulta);
            return correcto;
        }
        public bool Update(int id)
        {
            bool correcto = false;
            string consulta = $"UPDATE Libros SET Titulo='{Titulo}',Autor='{Autor}',Editorial='{Editorial}',Genero='{Genero}',Ubicación='{Ubicacion}',Copias='{CopiasDisponibles}' WHERE Id ='{id}'";
            correcto = BaseDatos.ExecuteQuery(consulta);
            return correcto;
        }
    }
}
