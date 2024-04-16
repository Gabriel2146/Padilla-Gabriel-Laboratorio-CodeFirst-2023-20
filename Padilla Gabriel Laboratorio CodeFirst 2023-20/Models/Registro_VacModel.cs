namespace Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Models
{
    public class Registro_VacModel
    {
        public int Id { get; set; }

        public EstudianteModel Estudiante { get; set; }
        public VacunaModel Vacuna { get; set; }
        public DateTime FechaVacunacion { get; set; }
        public RecintoModel Recinto { get; set; }
    }
}
