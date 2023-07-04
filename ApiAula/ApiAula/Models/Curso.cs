namespace ApiAula.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }

        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
