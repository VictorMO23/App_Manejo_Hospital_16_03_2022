using System;

namespace Negocio
{
    public class clsCitas
    {
        private int int_no_cita = 0;
        private int int_id_pacien = 0;
        private int int_codigo_medico = 0;
        private int int_fecha = 0;
        private String str_motivo = "";

        public clsCitas(int no, int id, int co, int fe, String mo)
        {
            this.int_no_cita = no;
            this.int_id_pacien = id;
            this.int_codigo_medico = co;
            this.int_fecha = fe;
            this.str_motivo = mo;
        }

        // Solo Geters, ya que como no se va ha actualizar información no pusimos los Seter por esa razón.

        public int getNo_Cita() { return this.int_no_cita; }
        public int getId_paciente() { return this.int_id_pacien; }
        public int getCod_Medico() { return this.int_codigo_medico; }
        public int getFecha() { return this.int_fecha; }
        public String getMotivo() { return this.str_motivo; }
    }
}
