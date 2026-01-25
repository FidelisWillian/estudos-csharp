using metodosCsharp.models;

Pessoa p = new Pessoa();
p.nome = "Willian";
p.sobrenome = "Fidelis";

Pessoa p1 = new Pessoa();
p1.nome = "Lorena";
p1.sobrenome = "Camilli";

Curso c = new Curso();
c.Alunos = new List<Pessoa>();
c.Nome = "Curso de C#";
c.AdicionarAluno(p);
c.AdicionarAluno(p1);
c.ListarAlunos();