Console.Clear();

string[] assassino = ["Zumbi", "Assassino", "Psicopata", "Alienígena", "Carniceiro", "Matador",
                      "Vampiro", "Maluco", "Vingador", "Monstro", "Bruxo", "Demônio"];
string[] adjetivo = ["Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído", "Macabro",
                     "Sombrio", "Sem Cabeça", "Desconhecido", "Inconsciente", "Oculto", "Esquecido",
                     "Lúgubre", "Invocado", "Caído", "Costurado", "Amaldiçoado", "Anormal",
                     "Perturbado", "Sanguinário", "Tenebroso", "Imortal", "Ressuscitado", "do Pântano",
                     "da Encruzilhada", "do Porão", "do Velho Poço", "sem Perdão", "do Cemitério",
                     "da Meia-Noite", "da Lua Cheia"];
string[] data = ["janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho",
                 "agosto", "setembro", "outubro", "novembro", "dezembro"];
int dia;
int mes;

Console.WriteLine("---Noite de Terror---");

Console.WriteLine("\nQual o dia de nascimento da vítima (1 a 31)?");
dia = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Qual o mês de nascimento da vítima (1 a 12)?");
mes = Convert.ToInt32(Console.ReadLine()!);

if (1 > dia || 31 < dia || 1 > mes || 12 < mes)
{
    corVermelho();
    Console.WriteLine("\ndata inválida");
    corReset();
    return;
}

Console.Clear();

Console.WriteLine("---Noite de Terror---");


Console.WriteLine($"\nDia: {dia} de {data[mes - 1]}");
Console.Write("CUIDADO! O ");
corVinho();
Console.Write($"{assassino[mes - 1]} {adjetivo[dia - 1]}");
corReset();
Console.Write(" começou a te perseguir!");

void corVermelho()
{
    Console.ForegroundColor = ConsoleColor.Red;
}

void corVinho()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
}

void corReset()
{
    Console.ResetColor();
}