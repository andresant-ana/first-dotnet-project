namespace rm551575.Models
{
    internal class Aluno : Usuario
    {
        public Aluno(string nome, string email, int rm) : base(nome,email)
        {
            if (rm == 0) 
            {
                Random rdn = new Random();
                Rm = rdn.Next(1, 10000);
            }
            else
            {
                Rm = rm;
            }
        }

        public int Id { get; set; }

        public int Rm { get; set; }

        public string RetornaCodigo()
        {
            return $"O RM do aluno é RM{Rm}";
        }

    }
}
