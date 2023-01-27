namespace BE_CRUDMascotas.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;
        public string Raza { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public int Edad { get; set; }

        public float Peso { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
