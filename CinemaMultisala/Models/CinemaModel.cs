namespace CinemaMultisala.Models
{
    public class CinemaModel
    {
        private Guid guid = new Guid();
        private string? Nome { get; set; }
        private string? Cognome { get; set; }
        private int NumeroPosti { get; set; }

        private string? NomeSala { get; set; }
    }
}
