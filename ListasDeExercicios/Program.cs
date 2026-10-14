//Lista 1

// 1. Escreva um programa que use o comando Console.WriteLine() para exibir a frase "Olá, Mundo!" no console.
Console.WriteLine("Olá, mundo!");

// 2. Crie um programa que declare uma variável inteira chamada numero com o valor 10. Em seguida, imprima o valor dessa variável no console.
int número = 10;
Console.WriteLine(número);

// 3. Escreva um programa que declare duas variáveis inteiras, a = 5 e b = 3. Calcule a soma das duas e imprima o resultado.

int a = 5;
int b = 3;

int soma = a + b;
Console.WriteLine(soma);

// 4. Declare duas variáveis, num1 = 8 e num2 = 7. Calcule o produto (multiplicação) entre elas e imprima o resultado.
int núm1 = 8;
int núm2 = 7;

int multiplicação = núm1 * núm2;
Console.WriteLine(multiplicação);


// 5. Crie um programa que declare uma variável String chamada nome com o valor "Ana". Depois, exiba uma mensagem de boas-vindas, como "Olá, Ana!".
string Nome = "Ana";
Console.WriteLine($"Olá, {Nome} !");

// 6. Declare uma variável inteira valor. Em seguida, calcule o dobro desse número utilizando a variável e exiba o resultado.
int Valor = 20;
int Dobro = Valor * 2;

Console.WriteLine(Dobro);

// 7. Escreva um programa que recebe três números e imprime a média aritmética deles.

Console.WriteLine("Digite o primeiro número:");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
double n3 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3) / 3;

Console.WriteLine(media);


// 8. Peça ao usuário que digite, um de cada vez, o seu nome, a sua idade e a sua cidade. Depois, monte uma única frase com as três informações.

Console.WriteLine("Digite seu nome: ");
string nome1 = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite sua cidade: ");
string cidade = Console.ReadLine();

Console.WriteLine($"{nome1} tem {idade} anos e mora em {cidade}.");


// 9. Escreva um programa que declare duas variáveis inteiras, x = 10 e y = 20. O programa deve comparar se x é menor que y (<) e imprimir o resultado (true ou false) no console.

int x = 10;
int y = 20;

// bool -> Tipo que armazena true ou false APENAS.

bool resultado = x < y;

Console.WriteLine(resultado);

 //10. Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar se a idade é maior ou igual a 16 e imprimir o resultado (`true` ou `false`). 
 //**Extra:**Adicione um comentário de uma linha (`//`) explicando o que a comparação faz.

Console.WriteLine("Informe sua idade: "); //Não foi solicitado no enunciado, porém pela experiência do usuário é essencial
int idadeUsuario = int.Parse(Console.ReadLine());

if (idadeUsuario >= 16)
{
    Console.WriteLine("true");
}
else
{  
    Console.WriteLine("false");
}

 //11. Declare uma variável int temperatura = 28. Escreva uma expressão lógica que verifique se atemperatura é maior que 25 E menor que 30. Imprima o resultado true ou false no console.

int temperatura = 28;

if (temperatura > 25 && temperatura < 30)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

 //12. Declare uma variável booleana temCartao = true e uma variável double compra = 50.0. O cliente ganha um desconto se temCartao for verdadeiro OU se o valor da compra for maior que 100.0.
 //Escreva a expressão lógica e imprima o resultado ( `true` ou `false`).

bool temCartao = true;
double compra = 50.0;

if (temCartao == true || compra > 100)
{
    Console.WriteLine("Tem desconto!");
}




 // Lista 2

 //1. Crie um programa que declare uma variável **`idade`**. 
 //Use uma estrutura **`if/else`** para verificar se a idade é **maior ou igual a 18**. 
 //O programa deve imprimir "*Você é maior de idade*" se a condição for verdadeira, e "*Você é menor de idade*" caso contrário

int Idade = 20; // < -Pode ser assim
int Idade1 = int.Parse(Console.ReadLine()); // < -Pode ser dessa forma também
if (Idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
}
else
{
    Console.WriteLine("Você é menor de idade");
}

//2. Crie um programa que declare uma variável **`numero`**; 
// Utilize uma estrutura **`if/else if/else`** para verificar e imprimir uma das seguintes mensagens: "*O número é positivo.*", "*O número é negativo.*" ou "*O número é zero.*".

int numero = 20;
if (numero > 0)
{
    Console.WriteLine("O número é positivo");
}
else if (numero < 0)
{
    Console.WriteLine("O número é negativo");
}
else
{
    Console.WriteLine("O número é zero");
}

 //3. Crie um programa que use a classe para pedir ao usuário que digite a nota de um aluno (um valor **`double`**). 
 //Em seguida, use uma estrutura **`if/else`** simples para imprimir "Aprovado" se a nota for maior ou igual a 7.0, e "Reprovado" caso contrário

Console.WriteLine("Digite a nota do aluno:");
double nota = double.Parse(Console.ReadLine());
if (nota >= 7.0)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

 //4. Peça a idade do usuário e classifique: até 12 anos → "Criança", de 13 a 17 → "Adolescente", 18 ou mais → "Adulto". Use condicional encadeada (else if).

int idade = 18;
if (idade >= 18)
{
    Console.WriteLine("Adulto");
}
else if (idade >= 13)
{
    Console.WriteLine("Adolescente");
}
else
{
    Console.WriteLine("Criança");
}

 //5. Declare uma variável **`boolean tarefaConcluida`**. 
 //Usando uma estrutura **`if/else`**, exiba a mensagem "A tarefa está pendente!" se a variável for **`false`**, e "A tarefa foi finalizada com sucesso!" se for **`true`**.

bool tarefaConcluida = false;

if (tarefaConcluida = false)
{
    Console.WriteLine("A tarefa está pendente!");
}
else
{
    Console.WriteLine("A tarefa foi finalizada com sucesso!");
}

 //6. Peça uma nota ao usuário. Use o operador && para verificar se ela está dentro do intervalo válido (entre 0 e 10). Exiba "Nota válida" ou "Nota inválida".

Console.WriteLine("Digite uma nota");

int nota = int.Parse(Console.ReadLine());

if (nota > 0 && nota < 10)
{
    Console.WriteLine("Nota válida");
}
else
{
    Console.WriteLine("Nota inválida");
}

 //7. Para aprovar um empréstimo, um banco exige que o cliente tenha um salário mensal de pelo menos R$ 2.000,00 e não possua restrições de crédito. 
 //Crie um programa com as variáveis **`double salarioMensal`**; e * *`boolean possuiRestricao`**
 //Use o operador lógico "E" (**`&&`**) em uma estrutura **`if`** para determinar e imprimir "Empréstimo aprovado." ou "Empréstimo negado."

Console.WriteLine("Digite o salário do cliente:");
double salarioMensal = double.Parse(Console.ReadLine());
bool possuiRestricao = false;

if (salarioMensal >= 2000 && possuiRestricao == false)
{
    Console.WriteLine("Empréstimo aprovado!");
}
else
{
    Console.WriteLine("Empréstimo negado!");
}


// 8. Crie um programa que solicita ao usuário que digite uma nota (um valor **`double`**). Utilizando uma estrutura **`if/ else if /else`**, classifique a nota da seguinte forma:
//-Se a nota for 7.0 ou maior, imprima "Aprovado!".
//- Se a nota for maior ou igual a 5.0, mas menor que 7.0, imprima "Recuperação.".
//- Se a nota for menor que 5.0, imprima "Reprovado.".

Console.WriteLine("Digite a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado!");
}
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Recuperação.");
} 
else
{
    Console.WriteLine("Reprovado");
}


//9. Declare uma variável numero; Utilizando o operador ternário (? :), crie uma variável String resultado que receba o texto "Par" se o número for par, ou "Ímpar" se for ímpar.
//Ao final, imprima o resultado.

Console.WriteLine("Digite um número: ");
double numero = double.Parse(Console.ReadLine());

string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";

Console.WriteLine(resultado);


// 10. Uma loja oferece descontos baseados no valor da compra. Crie um programa que declare uma variável `double valorCompra = 150.0;` e aplique as seguintes regras usando `if/else if/else`:
//-Compras acima de R$ 200,00 têm 20% de desconto.
//- Compras entre R$ 100,00 (inclusive) e R$ 200,00 (exclusive) têm 10% de desconto.
//- Compras abaixo de R$ 100,00 não têm desconto. 
//    O programa deve usar os operadores aritméticos para calcular e exibir o valor final a ser pago.

double porcentagemDesconto = 0.0;

Console.WriteLine("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine());

if (valorCompra > 200.00)
{
    porcentagemDesconto = 0.20;
}
else if (valorCompra >= 100.00 || valorCompra <= 200.00)
{
    porcentagemDesconto = 0.10;
}
else
{
   porcentagemDesconto = 0.0;
}

double valorDesconto = valorCompra * porcentagemDesconto;
double valorFinal = valorCompra - valorDesconto;

Console.WriteLine($"Valor original da compra: R$ {valorCompra:F2}");
Console.WriteLine($"Desconto aplicado: {porcentagemDesconto * 100}% (R$ {valorDesconto:F2})");
Console.WriteLine($"Valor final a pagar: R$ {valorFinal:F2}");






 //Lista 3


 //1. Peça uma senha ao usuário. Enquanto ele não digitar 123, exiba "Senha incorreta!" e peça novamente. Quando acertar, exiba "Acesso liberado!".

string senha = "";

do
{
    Console.WriteLine("Digite sua senha: ");
    senha = Console.ReadLine();

    if (senha != "123")
    {
        Console.WriteLine("Senha incorreta! Tente novamente");
    }
    else
    {
        Console.WriteLine("Acesso liberado!");
    }

} while (senha != "123");



 //2. Use um laço while para imprimir os números de 1 a 10.

int contador = 1;
while (contador <= 10)
{

Console.WriteLine($"Número: {contador}");
    contador++; 

}
Console.WriteLine("Acabou!");



 //3. Exiba a mensagem "Executando o processo..." e pergunte se o usuário deseja executar novamente. Se ele digitar s ou S, repita. Caso contrário, exiba "Processo encerrado!".

string resposta = "N";
bool repete = true;

do
{
    Console.WriteLine("Executando o processo..");
    Console.WriteLine("Deseja executar novamente?");
    resposta = Console.ReadLine();

    if (resposta == "s" || resposta == "S")
    {
        repete = true;
    }
    else
    {
        repete = false;
        Console.WriteLine("Processo encerrado!");
    }

} while (repete);




//4. Peça números inteiros ao usuário e vá somando todos. O laço para quando o usuário digitar 0. No final, exiba a soma total.

int soma = 0;
int numero;

do
{
 Console.Write("Digite um número inteiro (ou 0 para sair): ");

 while (!int.TryParse(Console.ReadLine(), out numero))
{
Console.Write("Entrada inválida. Por favor, digite um número inteiro: ");
}

soma += numero;

} while (numero != 0);

Console.WriteLine($"\nA soma total dos números digitados é: {soma}");



 //5. Peça um número ao usuário e exiba a tabuada dele, de 1 a 10.


Console.Write("Digite um número para ver a tabuada: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTabuada do {numero}:");


for (int i = 1; i <= 10; i++)
{
      int resultado = numero * i;
      Console.WriteLine($"{numero} x {i} = {resultado}");
}



 //6. Use um laço for para somar todos os números de 1 a 100 e exiba o resultado.

int soma = 0;

for (int i = 1; i < 100; i++)
{
    soma += i;
    Console.WriteLine($"A soma dos números de 1 a 100 é: {soma}");
}



 //7. Crie um cadastro que peça uma senha ao usuário. Use do-while para garantir que ela tenha no mínimo 8 caracteres.
 //Enquanto for curta, exiba "Senha muito curta. A senha deve ter no mínimo 8 caracteres." e peça novamente. Quando for válida, exiba "Senha cadastrada com sucesso!".

string senha;

do
{
    Console.Write("Digite a sua senha: ");
    senha = Console.ReadLine();

    if (senha.Length < 8)
    {
        Console.WriteLine("Senha muito curta. A senha deve ter no mínimo 8 caracteres.");
    }

} while (senha.Length < 8);

Console.WriteLine("Senha cadastrada com sucesso!");


 //8. Peça um número inteiro não negativo e calcule o seu fatorial.
 //O fatorial de `n` (escrito `n!`) é o produto de todos os inteiros positivos até `n`.
 //Exemplo: `5! = 5 × 4 × 3 × 2 × 1 = 120`.

Console.Write("Digite um número inteiro não negativo: ");

if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
{
    long fatorial = 1;


    for (int i = 1; i <= n; i++)
    {
        fatorial *= i;
    }


    Console.WriteLine($"O fatorial de {n} ({n}!) é: {fatorial}");
}
else
{
    Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro maior ou igual a zero.");
}

 //9. O programa sorteia um número inteiro entre 1 e 100.
 //O jogador tenta adivinhar qual é.
 //A cada tentativa, informe se o número secreto é maior ou menor que o palpite.
 //O jogo termina quando o jogador acerta.
 //No final, mostre quantas tentativas foram necessárias.

Random random = new Random(); // Cria uma instância de Random para gerar números aleatórios
int numeroSecreto = random.Next(1, 101); // Número entre 1 e 100
int tentativas = 0; // Contador de tentativas
int limiteTentativas = 5; // Limite de tentativas

Console.WriteLine("\nBem-vindo ao Jogo do Número Secreto!");
Console.WriteLine($"Você tem {limiteTentativas} tentativas para adivinhar o número secreto.");

// Loop principal do jogo
while (tentativas < limiteTentativas)
{
    Console.Write($"Tentativa {tentativas + 1} de {limiteTentativas}. Tente adivinhar o número secreto entre 1 e 100: ");
    string entrada = Console.ReadLine()!;
    int palpite;

    // Verifica se a entrada é um número válido
    if (!int.TryParse(entrada, out palpite))
    {
        Console.WriteLine("Por favor, digite um número válido.");
        continue;
    }

    // Verifica se o palpite está dentro do intervalo permitido
    if (palpite < 1 || palpite > 100)
    {
        Console.WriteLine("O número deve estar entre 1 e 100. Tente novamente!");
        continue;
    }

    tentativas++;

    // Verifica se o palpite é correto
    if (palpite == numeroSecreto)
    {
        Console.WriteLine(@"
███████╗  ██╗░██████╗░██████╗░█████╗░  ░█████╗░██╗██╗
██╔════╝  ██║██╔════╝██╔════╝██╔══██╗  ██╔══██╗██║██║
█████╗░░  ██║╚█████╗░╚█████╗░██║░░██║  ███████║██║██║
██╔══╝░░  ██║░╚═══██╗░╚═══██╗██║░░██║  ██╔══██║██║╚═╝
███████╗  ██║██████╔╝██████╔╝╚█████╔╝  ██║░░██║██║██╗
╚══════╝  ╚═╝╚═════╝░╚═════╝░░╚════╝░  ╚═╝░░╚═╝╚═╝╚═╝

██╗░░░██╗░█████╗░░█████╗░███████╗  ░█████╗░░█████╗░███████╗██████╗░████████╗░█████╗░██╗░░░██╗██╗
██║░░░██║██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔══██╗██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██║░░░██║██║
╚██╗░██╔╝██║░░██║██║░░╚═╝█████╗░░  ███████║██║░░╚═╝█████╗░░██████╔╝░░░██║░░░██║░░██║██║░░░██║██║
░╚████╔╝░██║░░██║██║░░██╗██╔══╝░░  ██╔══██║██║░░██╗██╔══╝░░██╔══██╗░░░██║░░░██║░░██║██║░░░██║╚═╝
░░╚██╔╝░░╚█████╔╝╚█████╔╝███████╗  ██║░░██║╚█████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝╚██████╔╝██╗
░░░╚═╝░░░░╚════╝░░╚════╝░╚══════╝  ╚═╝░░╚═╝░╚════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░░╚═════╝░╚═╝");
        Console.WriteLine($"\nParabéns! Você adivinhou o número secreto em {tentativas} tentativas!");
        break;
    }
    else if (palpite < numeroSecreto)
    {
        Console.WriteLine("Seu palpite é muito baixo. Tente novamente!");
    }
    else
    {
        Console.WriteLine("Seu palpite é muito alto. Tente novamente!");
    }
}

// Verifica se o jogador esgotou as tentativas
if (tentativas == limiteTentativas)
{
    Console.WriteLine($"\nSuas tentativas acabaram! =/ O número secreto era {numeroSecreto}.");
    Console.WriteLine("Obrigado por jogar! ;)");
}



// 10. Desenvolva uma calculadora com as quatro operações básicas. O programa deve:
//1.Exibir um menu com as opções (somar, subtrair, multiplicar, dividir, sair).
//2. Pedir ao usuário para escolher uma operação.
//3. Pedir dois números.
//4. Exibir o resultado.
//5. Voltar ao menu, repetindo até que o usuário escolha "Sair".

int opcao = 0;

do
{
    Console.Clear();
    Console.WriteLine("=== Calculadora Simples ===");
    Console.WriteLine("1. Somar");
    Console.WriteLine("2. Subtrair");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha uma opção (1-5): ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opção inválida! Pressione Enter para continuar.");
        Console.ReadLine();
        continue;
    }

    if (opcao == 5)
    {
        Console.WriteLine("Encerrando o programa...");
        break;
    }

    if (opcao < 1 || opcao > 5)
    {
        Console.WriteLine("Opção inválida! Escolha entre 1 e 5. Pressione Enter para continuar.");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Número inválido! Pressione Enter para continuar.");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Número inválido! Pressione Enter para continuar.");
        Console.ReadLine();
        continue;
    }

    double resultado = 0;
    bool operacaoValida = true;

    switch (opcao)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"Resultado da Soma: {num1} + {num2} = {resultado}");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"Resultado da Subtração: {num1} - {num2} = {resultado}");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"Resultado da Multiplicação: {num1} * {num2} = {resultado}");
            break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero!");
                operacaoValida = false;
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine($"Resultado da Divisão: {num1} / {num2} = {resultado}");
            }
            break;
    }

    Console.WriteLine("\nPressione Enter para voltar ao menu...");
    Console.ReadLine();

} while (opcao != 5);


 //11. Liste todos os números primos entre 1 e 100.
 //Um número primo é um número natural maior que 1 que só é divisível por 1 e por ele mesmo.
 //*Dica: você vai precisar de um `for` dentro de outro. O laço externo percorre os números de 2 a 100 e o interno verifica se existe algum divisor.
 //O comando `break` ajuda a sair do laço interno assim que um divisor é encontrado.*

Console.WriteLine("Números primos entre 1 e 100:");

for (int i = 2; i <= 100; i++)
{
    bool ehPrimo = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            ehPrimo = false;
            break; 
        }
    }

    if (ehPrimo)
    {
        Console.Write(i + " ");
    }
}

 //12. Peça um número `N` ao usuário e exiba os `N` primeiros termos da sequência de Fibonacci.
 //Na sequência, cada termo é a soma dos dois anteriores: `0, 1, 1, 2, 3, 5, 8, 13, 21...`







 Atividade em grupo:


int opcao;
double salario, novoSalario, ferias, decimo;
int meses;

do
{
    Console.WriteLine("=== MENU ===");
    Console.WriteLine("1. Novo salário");
    Console.WriteLine("2. Férias");
    Console.WriteLine("3. Décimo terceiro");
    Console.WriteLine("4. Sair");
    Console.WriteLine("\n Digite a opção desejada: ");

    opcao = int.Parse(Console.ReadLine());

    // switch    case

    switch (opcao)  // analisa essa variável
    {
        case 1:
            Console.WriteLine("Informe o salário: R$ ");
            salario = double.Parse(Console.ReadLine());
            if (salario <= 350)
                novoSalario = salario * 1.15;
            else if (salario <= 600)
                novoSalario = salario * 1.10;
            else
                novoSalario = salario * 1.05;

            Console.WriteLine($"Novo salário: R$ {novoSalario}");

            break;
        case 2:
            Console.WriteLine("Informe o salário: R$ ");
            salario = double.Parse(Console.ReadLine());

            ferias = salario + (salario / 2);

            Console.WriteLine($"Valor das férias: R$ {ferias}");

            break;
        case 3:
            Console.WriteLine("Informe o salário: R$ ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe os meses trabalhados: ");
            meses = int.Parse(Console.ReadLine());

            decimo = (salario * meses) / 12;

            Console.WriteLine($"Décimo terceiro: R$ {decimo.ToString("F2")}");

            break;
        case 4:

            Console.WriteLine("Programa encerrado.");


            break;

        default:
            Console.WriteLine("Opção ínválida."); break;
    }
}
while (opcao != 4);


 //Lista 1 - Funções


 //1. Crie uma função sem retorno chamada ExibirBoasVindas que não receba parâmetros e exiba no console a mensagem: "Bem-vindo ao curso de C#!".
 //Chame a função duas vezes.

void ExibirBoasVindas()
{
    Console.WriteLine("Bem-vindo ao curso de C#!");
}

ExibirBoasVindas();
ExibirBoasVindas();


 //2. Crie uma função chamada Dobro que receba um número inteiro e retorne o dobro dele.
 //Exiba o resultado para os números 4, 15 e 100.

int Dobro(int numero)
    {
        return numero * 2;
    }

{
    Console.WriteLine($"O dobro de 4 é: {Dobro(4)}");
    Console.WriteLine($"O dobro de 15 é: {Dobro(15)}");
    Console.WriteLine($"O dobro de 100 é: {Dobro(100)}");
}


 //3. Crie uma função chamada EhPar que receba um número inteiro e retorne true se ele for par ou false se for ímpar.
 //Teste com os números 7 e 10, exibindo no console se cada um é par ou ímpar.

bool EhPar(int numero)
{
    return numero % 2 == 0;
}

int numero1 = 7;
if (EhPar(numero1))
{
    Console.WriteLine($"{numero1} é par.");
}
else
{
    Console.WriteLine($"{numero1} é ímpar.");
}

int numero2 = 10;
if (EhPar(numero2))
{
    Console.WriteLine($"{numero2} é par.");
}
else
{
    Console.WriteLine($"{numero2} é ímpar.");
}

 //4. Crie uma função sem retorno chamada SaudarAluno que receba o nome do aluno e o nome do curso.
 //O curso deve ter o valor padrão "Programação"
 //.A função deve exibir: "Olá, [nome]! Bem-vindo ao curso de [curso].".
 //Chame a função uma vez informando só o nome e outra vez informando nome e curso.


void SaudarAluno(string nome, string curso = "Programação")
{
    Console.WriteLine($"Olá, {nome}! Bem-vindo ao curso de {curso}.");
}

SaudarAluno("Carlos");
SaudarAluno("Ana", "Programação");


// 5. Crie duas funções:

//- `CalcularMedia`: recebe três notas (`double`) e retorna a média.
//- `ObterSituacao`: recebe a média e retorna uma `string`:
//    - `"Aprovado"` se a média for maior ou igual a 7
//    - `"Recuperação"` se a média for maior ou igual a 5 e menor que 7
//    - `"Reprovado"` se a média for menor que 5

//Peça as três notas ao usuário, calcule a média e exiba a média e a situação.


double CalcularMedia(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3) / 3;
}
string ObterSituacao(double media)
{
        if (media >= 7)
        {
            return "Aprovado!";
        }
        else if (media < 5)
        {
            return "Reprovado";
        }
        else
        {
            return "Em recuperação";
        }
}


Console.WriteLine("Digite a primeira nota: ");
double nota1 = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Digite a segunda nota: ");
double nota2 = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Digite a terceira nota: ");
double nota3 = int.Parse(Console.ReadLine());

Console.WriteLine();

double media = CalcularMedia(nota1, nota2, nota3);
Console.WriteLine($"A sua média é {media} e você está {ObterSituacao(media)}");



 //6. Crie uma função sem retorno chamada ExibirTabuada que receba um número inteiro e um limite (valor padrão = 10).
 //A função deve exibir a tabuada do número de 1 até o limite, no formato 5 x 1 = 5.
 //Teste chamando ExibirTabuada(7) e ExibirTabuada(3, 5).


void ExibirTabuada(int numero, int limite = 10)
{
    for (int i = 1; i<= limite; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}