using Infraestructura.Datos;
using Infraestructura.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ContactosServices
{
    public class UsuarioService
    {
        UsuarioDatos usuarioDatos;
        public UsuarioService(string cadenaConexion)
        {
            usuarioDatos = new UsuarioDatos(cadenaConexion);
        }

        public void insertarUsuario(UsuarioModel usuario)
        {
           
            usuarioDatos.insertarUsuario(usuario);
        }

        public UsuarioModel obtenerUsuarioPorId(int id)
        {
            return usuarioDatos.obtenerUsuarioPorId(id);
        }

        public void modificarUsuario(UsuarioModel usuario)
        {
            
            usuarioDatos.modificarUsuario(usuario);
        }

        public void eliminarUsuario(UsuarioModel usuario)
        {
            
            usuarioDatos.eliminarUsuario(usuario);
        }
    }
}
