

//Comparar valores -True(verdadeiro) ou False (falso)

int a = 10, b = 20;

 = ->atribuição

 == ->comparação de igualdade

Console.WriteLine(a == b); // A é igual a B? - False
Console.WriteLine(a != b); // A é diferente de B? - True
Console.WriteLine(a > b); // A é maior do que B?  False
Console.WriteLine(a < b); // A é menor do que B?  True

Console.WriteLine(a >= b); // A é maior ou igual a B? False
Console.WriteLine(a <= b); // A é menor ou igual a B? True



//Nomenclatura
 Variáveis -> camelCase = a primeira palavra começa com letra minúscula e as seguintes com letra maiúscula
 int idadeDoAluno = 9;

Métodos, Classes -> PascalCase = todas as palavras começam com maiúscula
 Console.WriteLine();



Operadores Lógicos(Juntar perguntas)
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





