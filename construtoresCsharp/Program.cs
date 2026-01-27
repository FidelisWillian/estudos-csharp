using construtoresCsharp.models;

Pessoa p = new Pessoa(nome: "Willian",sobrenome: "Fidelis");
Pessoa p1 = new Pessoa(nome:"Lorena", sobrenome:"Fidelis");


Curso c = new Curso();
c.Alunos = new List<Pessoa>();
c.Nome = "Curso de C#";
c.AdicionarAluno(p);
c.AdicionarAluno(p1);
c.ListarAlunos();