Livro l1 = new();

l1.titulo = "Rápido e devagar";
l1.autor = "Daniel kanneman";
l1.disponibilidade = true;

Livro l2 = new();

l2.titulo = "Agulha e preconceito";
l2.autor = "jane da salada de fruta";
l2.disponibilidade = true;

Livro l3 = new();

l2.titulo = "Akenathon";
l2.autor = "Um nou";
l2.disponibilidade = false;

Biblioteca b1 = new();
b1.nome = "Enzo Libraly";
b1.AdicionarLivro(l1);
b1.AdicionarLivro(l2);
b1.AdicionarLivro(l3);


Livro lResult = new ();
lResult = b1.BuscarPorTitulo("Akinator");
b1.BuscarPorTitulo("Akinator");
Console.WriteLine(lResult.autor);

