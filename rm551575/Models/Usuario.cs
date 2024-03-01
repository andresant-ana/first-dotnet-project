using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace rm551575.Models
{
    public class Usuario
    {
        public Usuario(string nome, string email)
        {
            if (nome == "")
            {
                throw new ArgumentNullException("O nome está vazio");
            }
            Nome = nome;
            Email = email;

        }

        private string Nome {  get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Codigo { get; set; }
        public DateTime DataNascimento { get; set; }

        public string GetNome()
        {
            return $"O nome do aluno é {Nome}";
        }

    }
}
