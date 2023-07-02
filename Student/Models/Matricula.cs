namespace Student.Models
{
    public class Matricula
    {
        public int MatriculaID { get; set; }
        public DateTime FechaMatricula { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante? estudiantes { get; set; }
    }
}
