using System;

namespace Negocio
{
    public class clsMedicos
    {
        private int int_cod = 0;
        private String str_nombre = "";
        private double dbl_contacto = 0;
        private int int_sexo = 0;

        public clsMedicos (int co, String no, double con, int se)
        {
            this.int_cod = co;
            this.str_nombre = no;
            this.dbl_contacto = con;
            this.int_sexo = se;
        }

        // Solo Geters, ya que como no se va ha actualizar información no pusimos los Seter por esa razón.

        public int getCodigo() { return this.int_cod; }
        public String getNombre() { return this.str_nombre; }
        public double getContacto() { return this.dbl_contacto; }
        public int getSexo() { return this.int_sexo; }

    }
}
