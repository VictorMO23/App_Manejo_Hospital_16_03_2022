using System;

namespace Negocio
{
    public class clsPacientes
    {
        private int int_id = 0;
        private String str_nombre = "";
        private String str_eps = "";
        private double dbl_contacto = 0;
        private String str_direccion = "";
        private int int_sexo = 0;
        private String str_antecedentes = "";

        public clsPacientes (int id, String no, String ep, double co, String di, int se, String an)
        {
            this.int_id = id;
            this.str_nombre = no;
            this.str_eps = ep;
            this.dbl_contacto = co;
            this.str_direccion = di;
            this.int_sexo = se;
            this.str_antecedentes = an;
        }

        // Seters and Geters

        public void SetContacto(double c) { this.dbl_contacto = c; }
        public void SetDirección(String d) { this.str_direccion = d; }
        public void SetEps(String e) { this.str_eps = e; }

        public int getID() { return this.int_id; }
        public String getNombre() { return this.str_nombre; }
        public String getEps() { return this.str_eps; }
        public double getContacto() { return this.dbl_contacto; }
        public String getDireccion() { return this.str_direccion; }
        public int getSexo() { return this.int_sexo; }
        public String getAntecedentes() { return this.str_antecedentes; } 

    }
}
