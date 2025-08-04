using _7_dados_e_listas_com_.net_c_.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Sobrenome = "Silva";
pessoa1.Idade = 30;
pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Maria";
pessoa2.Sobrenome = "Oliveira";
pessoa2.Idade = 25;
pessoa2.Apresentar();

Pessoa pessoa3 = new Pessoa("Carlos", "Santos", 40);
pessoa3.Apresentar();

Pessoa pessoa4 = new Pessoa(nome: "Ana", sobrenome: "Souza", idade: 20);
pessoa4.Apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);

cursoDeIngles.ListarAlunos();