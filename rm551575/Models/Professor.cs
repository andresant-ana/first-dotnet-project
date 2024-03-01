namespace rm551575.Models
{
    public class Professor : Usuario
    {
        public Professor(string nome, string email) : base(nome, email)
        {
            
        }

        public int Id { get; set; }

        public string CPF { get; set; }
    }

}
