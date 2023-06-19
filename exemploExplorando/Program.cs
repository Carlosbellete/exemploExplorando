using exemploExplorando;

Pessoa p1 = new Pessoa(nome: "Carlos", sobrenome: "Bellete");
Pessoa p2 = new Pessoa(nome: "Yanne", sobrenome: "Karoline");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.listarAlunos();


























//Pessoa p1 = new Pessoa();
//p1.Nome = "Carlos";
//p1.Sobrenome = "Bellete";
//p1.Idade = 23;
//p1.Apresentar();