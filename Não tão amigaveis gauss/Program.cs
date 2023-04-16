// See https://aka.ms/new-console-template for more information
using System.Globalization;
double distancia, velocidade_media;
int tempo;
Console.Write("Digite a distância percorrida em KM: ");
distancia = double.Parse(Console.ReadLine());
Console.Write("Digite o tempo decorrido em horas: ");
tempo = int.Parse(Console.ReadLine());
velocidade_media = distancia / tempo;
Console.WriteLine("a velocidade média foi: " + velocidade_media.ToString("F2", CultureInfo.InvariantCulture));


Console.Write("Digite a primeira nota: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
int B = int.Parse(Console.ReadLine());
double media = (A + B) / 2;
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

double peso, altura, imc;

Console.Write("Digite o seu peso: ");
peso = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());

imc = peso / (altura * altura);
Console.WriteLine("O seu imc é: " + imc.ToString("F1"));

Console.Write("Digite um nome: ");
string nome = Console.ReadLine();
int count = nome.Length;
Console.WriteLine($"O nome '{nome}' possui {count} caracteres.");

DateTime dataAniversarioUsuario;
var minhaData = new DateTime(2004, 2, 19);

bool converteu = false;
do
{
    Console.Write("Tente descobrir a minha data de nascimento, informe dd/mm/aaaa: ");
    converteu = DateTime.TryParse(Console.ReadLine(), out dataAniversarioUsuario);

} while (!converteu);

if (minhaData == dataAniversarioUsuario)
{
    Console.WriteLine("Você acertou a minha data de nascimento!!!!");
}
else
{
    Console.WriteLine("Você errou!!!!");
}

Console.WriteLine("Informe uma data em dd/mm/aaaa");
string[] data = Console.ReadLine().Split('/');
int dia = int.Parse(data[0]);
int mes = int.Parse(data[1]);
int ano = int.Parse(data[2]);
string mesExtenso;

switch (mes)
{
    case 01:
        mesExtenso = "Janeiro";
        break;
    case 02:
        mesExtenso = "Fevereiro";
        break;
    case 03:
        mesExtenso = "Março";
        break;
    case 04:
        mesExtenso = "Abril";
        break;
    case 05:
        mesExtenso = "Maio";
        break;
    case 06:
        mesExtenso = "Junho";
        break;
    case 07:
        mesExtenso = "Julho";
        break;
    case 08:
        mesExtenso = "Agosto";
        break;
    case 09:
        mesExtenso = "Setembro";
        break;
    case 10:
        mesExtenso = "Outubro";
        break;
    case 11:
        mesExtenso = "Novembro";
        break;
    case 12:
        mesExtenso = "Dezembro";
        break;
    default:
        mesExtenso = "Mês invalido";
        break;
}
Console.WriteLine("O mês correspondente ao número informado é {0}", mesExtenso);

Console.Write("Informe uma data (dd/mm/aaaa) ");
string data = Console.ReadLine();

string ano = data.Substring(6, 4);
Console.WriteLine("O ano da data informada é: {0} ", ano);

Console.Write("Informe uma data (dd/mm/aaaa) ");
string data = Console.ReadLine();

string dia = data.Substring(0, 2);
Console.WriteLine("O ano da data informada é: {0} ", dia);

DateTime hoje = DateTime.Today;
Console.WriteLine("Data de hoje: " + hoje.ToString("dd/MM/yyyy"));

const int numero = 10;
int distancia;
Console.Write("Digite um Número para calcular a distancia do valor de 10: ");
int valorUsuario = int.Parse(Console.ReadLine());

if(valorUsuario < 10)
{
    distancia = numero - valorUsuario;
}
else
{
    distancia = valorUsuario - numero;
}
Console.WriteLine("Distancia:{0} ", distancia);












Console.ReadKey();

