namespace BE_CRUDMascotas.Models.DTO
{
    public class MascotaDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;
        public string Raza { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public int Edad { get; set; }

        public float Peso { get; set; }
    }
}
