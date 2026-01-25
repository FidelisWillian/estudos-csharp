namespace metodosCsharp.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        // Void = o método irá retornar vazio
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        // O int quer dizer que esse método precisa retornar(return) um tipo de dado inteiro.
        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        // Esse metedo retorna true ou false, por ser do tipo "bool"
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                System.Console.WriteLine(aluno.nomeCompleto);
            }
        }
    }
}