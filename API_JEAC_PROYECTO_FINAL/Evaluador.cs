namespace API_JEAC_PROYECTO_FINAL
{
    public class Evaluador
    {
        public int IdEvaluador1 { get; set; }
        public int IdEvaluador2 { get; set; }
        public string NombreEvaluador1 { get; set; }
        public string NombreEvaluador2 { get; set; }
        public Evaluador(int id, string evaluador1, string evaluador2)
        {
            IdEvaluador1 = id;
            IdEvaluador2 = id;
            NombreEvaluador1 = evaluador1;
            NombreEvaluador2 = evaluador2;
        }
        public bool EstaDisponible()
        {
            // Lógica para determinar si el evaluador está disponible
            return true; // Ejemplo: siempre disponible
        }
    }
}
