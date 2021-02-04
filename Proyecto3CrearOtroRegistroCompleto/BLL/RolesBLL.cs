using Microsoft.EntityFrameworkCore;
using Proyecto3CrearOtroRegistroCompleto.DAL;
using Proyecto3CrearOtroRegistroCompleto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3CrearOtroRegistroCompleto.BLL
{
    public class RolesBLL
    {
        public static bool Guardar(Roles roles)
        {
            if (!Existe(roles.RolId))
                return Insertar(roles);
            else
                return Modificar(roles);
        }

        private static bool Insertar(Roles roles)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Roles.Add(roles);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Roles roles)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(roles).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.RolId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

    }
}
