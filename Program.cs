int dia, mes;

string[] caract = { "Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído", "Macabro", "Sombrio", "Sem Cabeça", "Desconhecido", "Inconsciente", "Oculto", "Esquecido", "Lúgubre", "Invocado", "Caído", "Costurado", "Amaldiçoado", "Anormal", "Perturbado", "Sanguinário", "Tenebroso", "Imortal", "Ressuscitado", "do Pântano", "da Encruzilhada", "do Porão", "do Velho Poço", "sem Perdão", "do Cemitério", "da Meia-Noite", "da Lua Cheia" };

string[] assassin = {"O Zumbi", "O Assassino", "O Psicopata", "O Alienígena", "O Carniceiro", "O Matador", "O Vampiro", "O Maluco", "O Vingador", "O Monstro", "O Bruxo", "O Demônio"};

do {
Console.Write("Digite o dia do seu nascimento: ");
dia = int.Parse(Console.ReadLine());

Console.Write("Digite mês do seu nascimento: ");
mes = int.Parse(Console.ReadLine());
}
while (dia < 1 || dia > 31 || mes > 1  || mes < 12) 

string selectCaract = caract[dia - 1]
string secAssasin = caract[mes - 1]

Console.WriteLine($"Fuja! Lá vem {selectCaract} {secAssasin}!",);

