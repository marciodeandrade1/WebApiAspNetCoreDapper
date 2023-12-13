namespace WebApiAspNetCoreDapper.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Pais { get; set; }

        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
    }
}
