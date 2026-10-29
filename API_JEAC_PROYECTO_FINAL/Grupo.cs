namespace API_JEAC_PROYECTO_FINAL
{
    public class Grupo
    {
        public int Id { get; set; }
        public List<string> Nombres { get; set; }
        public Grupo(int id)
        {
            Id = id;
            Nombres = new List<string>();
        }
    }
}
