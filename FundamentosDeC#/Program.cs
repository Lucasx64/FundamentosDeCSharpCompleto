

 = Comentário
 Toda INSTRUÇÃO termina com ponto e vírgula (;)

using System.Security.Authentication;

Console.WriteLine("Tenham uma boa noite!");


 Guardar informações
 Variáveis (Caixinhas que guardam informação)

 TIPO NOME_DA_VARIÁVEL = VALOR; <- (Estrutura de uma variável)
int Idade = 25;
string Nome = "Lucas";

Idade = 20;

 Console.WriteLine(Idade);
 Console.WriteLine(Nome);

 int = para números inteiros
 double/float = para números fracionados (float = variação do double, com limite de números menor)
 string = para textos/caracteres em geral (toda string estará SEMPRE dentro de aspas "")

 Constantes (Variáveis que não mudam)
 É um valor que não pode ser alterado.
const double Pi = 3.14159;


 Console.WriteLine(Pi);


var nome = "Lucas"; // O C# entende que é uma string.
var Preço = 19.55; // O C# entende que é um double.


char InicialDoNome = 'L'; // char é utilizado para apenas um caractere e depois do sinal de igual o caractere será colocado dentro de aspas simples.



Console.WriteLine("Digite seu nome");
string NomeUsuário = Console.ReadLine(); // Para ler o texto digitado

Console.WriteLine("Informe sua idade");
int IdadeUsuário = int.Parse (Console.ReadLine()); // int.Parse para fazer a conversão do que será digitado para, nesse caso, um tipo de número inteiro


 Console.WriteLine("Olá, " + NomeUsuário + "! \nVocê tem " + IdadeUsuário + " anos."); // \n = Serve para quebrar a linha do texto quando o código rodar.


 Interpolação de Strings
Console.WriteLine($"Olá, {NomeUsuário}! \nVocê tem {IdadeUsuário} anos."); // Utilizamos o $ para interpolar as strings do código, é necessário colocar elas dentro de {}



// Operações aritméticas

int soma = 10 + 5;
int subtração = 10 - 5;
int multiplicação = 10 * 5;
int divisão = 10 / 2;


// Resto da divisão = Recebe o resto da divisão de 10 por 3.
int módulo = 10 % 3;


Console.WriteLine(soma);
Console.WriteLine(subtração);
Console.WriteLine(multiplicação);
Console.WriteLine(divisão);
Console.WriteLine(módulo);

Comparar valores -True(verdadeiro) ou False (falso)

int a = 10, b = 20;

 = ->atribuição

 == ->comparação de igualdade

Console.WriteLine(a == b); // A é igual a B? - False
Console.WriteLine(a != b); // A é diferente de B? - True
Console.WriteLine(a > b); // A é maior do que B?  False
Console.WriteLine(a < b); // A é menor do que B?  True

Console.WriteLine(a >= b); // A é maior ou igual a B? False
Console.WriteLine(a <= b); // A é menor ou igual a B? True



Nomenclatura
 Variáveis -> camelCase = a primeira palavra começa com letra minúscula e as seguintes com letra maiúscula
 int idadeDoAluno = 9;

Métodos, Classes -> PascalCase = todas as palavras começam com maiúscula
 Console.WriteLine();


Operadores de comparação

 Operadores Lógicos (Juntar perguntas)
bool A = true;
bool B = false;

 && -E
 (true - se as duas condições forem verdadeiras)
 (false - se um dos lados for falso)
    bool resultado = A && B;
Console.WriteLine(resultado);

 || -OU
 (true - se uma das expressões for verdadeira)
    (false - se as duas forem falsas)
bool Resultado = A || B;
Console.WriteLine(Resultado);

!-NÃO(negação)
 traz o oposto do que estiver na variável (true se torna false e false se torna true)
bool resultado = !A;
Console.WriteLine(resultado);


Condicionais
Tomar uma ação se o cara é maior de idade
 Criança, Adulto e Idoso
int idade = 20;

if (idade >= 60)
{
    Console.WriteLine("É idoso");
}
else if (idade >= 18)
{
    Console.WriteLine("É adulto");
}
else
{
    Console.WriteLine("É criança");
}


Operador Ternário(if / else abreviado) (if existe sem else, porém else não existe sem if)

int idadeAluno = 25;
string mensagem;

if (idadeAluno > 18)
{
    mensagem = "Maior de idade";
}
else
{
    mensagem = "Menor de idade";
}

// Mesmo código de cima, de forma abreviada

mensagem = (idadeAluno > 18) ? "Maior de idade" : "Menor de idade"; // Interrogação funciona como if.




Estruturas de Repetição (para ações que se repetem)


 while (enquanto)
 enquanto (condição for verdade) { faz algo }

 Exemplos:

Peço uma senha, enquanto a senha estiver errada, pergunto de novo
Console.WriteLine("Digite a senha: ");
string senha = Console.ReadLine();

// enquanto a senha é diferente de vini
while (senha != "vini")
{
    Console.WriteLine("Senha incorreta!");
}

Para que o código não continue rodando eternamente a mensagem "senha incorreta!", digite uma segunda linha de código:

Console.WriteLine("Digite a senha: ");
string senha = Console.ReadLine();

while (senha != "vini")
{
    Console.WriteLine("Senha incorreta!");

    Console.WriteLine("Digite a senha: ");
    senha = Console.ReadLine();

}



int contador = 1;
while (contador <= 5)
{
    // codigo se repete
    Console.WriteLine($"Repetição número: {contador}");

    // contador = contador + 1;
    contador++; // mesma coisa que: contador = contador + 1;

}
Console.WriteLine("Acabou!");



Use um laço WHILE para exibir apenas números pares de 1 até 20. (Dica: utilize if e operador %)

int numero = 1;
while (numero <= 20) // se repete até numero ser maior que 20
{
    if (numero % 2 == 0)  // para mostrar números ímpares basta alterar == para !=
    {
        Console.WriteLine(numero);
    }
    numero++; // adiciona mais 1
}


Faça um laço WHILE que o contador inicie em 30 e termine em 0;

int contador = 30;
while (contador >= 0) // enquanto contador for maior ou igual a 0.
{
    Console.WriteLine($"A contagem está em: {contador}");
    contador--;
}
Console.WriteLine("A contagem acabou!");




do/while (testa a condição DEPOIS de executar o bloco. dessa forma será executado ao menos 1 vez.


 Exemplos:

int idade = 1;
do
{
    Console.WriteLine($"Repetição do número {idade}");
    // o codigo será executado ao menos uma vez


} while (idade > 5); // condição


O usuário deve enviar a senha corretamente. Enquanto ele errar, solicite para enviar a senha novamente. A senha deve ser: Senai134.

string senha = "Senai134";

do
{
    Console.WriteLine("Digite sua senha: ");
    senha = Console.ReadLine();

} while (senha != "Senai134");

ou

string senha = "";

do
{
    Console.WriteLine("Digite sua senha: ");
    senha = Console.ReadLine();

    if (senha != "Senai134")
    {
        Console.WriteLine("Senha incorreta! Tente novamente");
    }
    else
    {
        Console.WriteLine("Senha correta!");
    }

} while (senha != "Senai134");




for

 for (inicialização; condição; incremento)
    {
        código que se repete
 }

Exemplos:


Utilizando o for, imprima do número 1 ao número 5:


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}


Utilizando o for, faça uma contagem regressiva de 10 até 1.

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}


Utilizando o for, exiba os números de 0 até 20, imprimindo de 2 em 2. Por exemplo: 0, 2, 4, 6, 8...

for (int i = 0; i <= 20; i += 2)  // O x da questão está no incremento, para imprimir de 2 em 2 deve-se colocar i+=2 ou i = i + 2.
{
    Console.WriteLine(i);
}

Revisão:

while e do/while ->Utilizamos quando não sabemos quando o código termina

 Exemplo:

Console.WriteLine("Informe a senha: ");
string senha = Console.ReadLine();

while (senha != "vini123")
{
    Console.WriteLine("Informe a senha: ");
    senha = Console.ReadLine();
}

Utilizando do/while para o mesmo exemplo:

string senha2;

do
{
    Console.WriteLine("Informe a senha: ");
    senha2 = Console.ReadLine();
} while (senha2 != "vini123");

Tudo que fazemos com while, conseguimos fazer com do/while. O do/while é utilizado para não repetir muito o código.


 for -> para (estrtutura de repetição mais utilizada; sabems exatamente quantas vezes deve-se repetir algo/algo vai acontecer)
 i -> indice
 int i = 0 -> onde o i começa
 i < 1000 -> quando o i termina
 i++ -> como o i se comporta

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}



Array(ou vetor) é uma estrutura que armazena uma coleção de tamanho de elementos do mesmo tipo.
 Você cria uma variável que irá guardar mais de um elemento do mesmo tipo. 

 Criando um array:
int[] numero = { 10, 20, 30, 40, 50 }; // No array ele conta a posição a partir do 0 (logo, posição 0 é o número 10, posição 1 é o número 20, posição 2 é o número 30, e assim por diante).
Console.WriteLine(numero[2]);   // <- Buscando um valor inserido no array a partir da posição.


O array sempre tem tamanho fixo.

/*int[] numeros = new int[5];*/ // <- informa que terá 5 posições.


int[] numero = { 10, 20, 30, 40, 50 }
;

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine(numero[i]);
}


Exemplo:
Crie um programa que receba um array de inteiros com cinco posições, preenchido pelo usuário.
 Em seguida, calcule e exiba a soma de todos os elementos do array.

int[] listaNumeros = new int[5]; // [] [] [] [] [] - informa que serão 5 espaços a serem armazenados com os elementos inseridos pelo usuário.
int soma = 0;

for (int i = 0; i < listaNumeros.Length; i++)
{
    Console.WriteLine("Digite um numero para a posição: " + i);
    listaNumeros[i] = int.Parse(Console.ReadLine());
    soma += listaNumeros[i];
}

Console.WriteLine("A soma dos elementos é: " + soma);



FUNÇÕES(também chamadas de MÉTODOS)
 são blocos de código que executam uma tarefa específica.

 Podem ou não receber parâmetros e podem ou não retornar valores.


 void -> sem retorno.
 Saudacao() -> sem parametro -> ()


using System.Numerics;

void Saudacao()
{
    Console.WriteLine("Olá, seja bem vindo.");    // Rodando o código agora, nada irá acontecer.
}

Saudacao();  // chamar a função. (sempre fora do void);


Função com retorno
 Podemos retornar um valor utilizando 'return'.

 int a, int b -> soma recebe 2 parâmetros do tipo int

 soma vai retornar um tipo int.

int soma (int a, int b)
{

    return a + b;


}

int resultado = soma(5254, 2984);
Console.WriteLine("Resultado: " + resultado);

int resultado2 = soma(587, 500);
Console.WriteLine("Resultado: " + resultado2);


void SaudacaoNome(string nome)
{
    Console.WriteLine($"Olá, seja bem vindo - {nome}");
}

SaudacaoNome("Lucas"); // Necessário inserir um valor na função SaudacaoNome para que possa mostrar no Console.WriteLine quando executar o código. Se deixar vazio, não mostrará nada.



Crie uma função chamada CalcularMedia que receba 2 parâmetros e retorne a média.

double CalcularMedia(double num1, double  num2)
{
    return (num1 + num2) / 2;
}
double media = CalcularMedia(15.5, 20.4);
Console.WriteLine("Resultado: " + media);