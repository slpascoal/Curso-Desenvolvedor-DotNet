using códigos.Models;

Pessoa p1 = new Pessoa(Nome: "Silas", Sobrenome: "Pascoal", Idade: 22);

Pessoa p2 = new Pessoa("Tayna", "Pascoal", 22);

Curso CursoDotNet = new Curso();
CursoDotNet.Nome = "Curso DotNet";
CursoDotNet.Alunos = new List<Pessoa>();

CursoDotNet.AdicionarAluno(p1);
CursoDotNet.AdicionarAluno(p2);

CursoDotNet.ListarAlunos();