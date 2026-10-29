// Usando Loop for
/*
for (int i = 0; i < 5; i++){ // length verifica e compara com o tamanho da lista, mas ele trata como int 
    Console.Write(i);
}
*/

// Loop while
/*
Console.Write("Qual é a idade do pericles: ");
int idadePericles = int.Parse(Console.ReadLine()!);
while (idadePericles != 57){
    Console.Write("Errou\n");
    Console.Write(idadePericles > 57 ? "Tente uma idade menor\n" : "Tente uma idade maior\n");
    idadePericles = int.Parse(Console.ReadLine()!);
}
Console.Write("Parabéns você acertou a idade dele");
*/

/*
int idadePericles;
do {
    Console.Write("informe a idade do periclao: ");
    idadePericles = int.Parse(Console.ReadLine()!);

    if (idadePericles == 57){
        break;
    }
    
    Console.Write(idadePericles > 56  ? "Tente uma idade menor\n" : "Tente uma idade maior\n");

} while (idadePericles != 57);
Console.Write("Parabéns você acertou a idade dele");
*/

// loop FOREACH
/*
using System.Runtime.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

string [] nomes = {"Camila", "Enzo", "Kaua", "Kaue", "Tamires"};

try{
    //Console.Write(nomes[5]);
    foreach (var item in nomes){ // o var é o tipo primitivo ou seja seria uma string item
        Console.Write(item + " ");
    }
} catch (IndexOutOfRangeException){// tratamento de erro fora do indice. tentar/pegar 
    Console.Write("o index está do alcance");
} // caso eu não queira colocar a exeception eu posso colocar apenas o catch para o tratamento

// outro exemplo 
int[] numeros = { 2, 4, 6, 8};
int variavelCriada = 0;
foreach (int nmr in numeros){ // variavel nmr recebe os valores da lista numeros;

    Console.WriteLine(nmr);
    variavelCriada += nmr; // acumulador recebe 2 + 4 + 6 + 8;
}

Console.WriteLine($"\nA soma dos números é de: {variavelCriada}");
*/


// Exercicios
/*
char resp = 'S';
while (resp == 'S' ){

    Console.Write("Você quer a tabuada de qual número: ");
    int numero = int.Parse(Console.ReadLine());

    for (int i = 1; i < 11; i++){ // ou <= 10 
        Console.Write($"{numero} X {i} = {numero * i}\n");
    }

    Console.Write("\nDeseja continuar: ");
    resp = char.Parse(Console.ReadLine().ToUpper()); // o ToUpper converte o valor para maiusculo 
}

// Usando o foreach 
/*
Console.Write("Você quer a tabuada de qual número: ");
int escolha  = int.Parse(Console.ReadLine());
int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int nmr in lista){ // nmr consulta e verifica o valores de lista 
    Console.Write($"{escolha} X {nmr} = {escolha * nmr}7\n");

}
*/

// Média com foreach 
// Faça um programa que leia 5 números e informe a soma e a média dos números
/*
int[] numeros = new int[5];
int somaValores = 0;

for (int i = 0; i < numeros.Length; i++){
    Console.Write("Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
    somaValores += numeros[i];
}
Console.Write($"A soma dos valores é de {somaValores} e a sua media é de {somaValores / numeros.Length}");
*/

// Faça um programa que ,dado um conjuto de N números, determine o menor valor, o maior e a soma dos valores

Console.Write("Quantos números você irá informar? ");
int QtdeN = int.Parse(Console.ReadLine()!);

int[] vetor = new int[QtdeN];
int soma = 0;
int maior = 0;
int menor = 0;

for (int i = 0; i < vetor.Length; i++){
    Console.Write("Digite um número: ");
    vetor[i] = int.Parse(Console.ReadLine()!);
    soma += vetor[i];
}

for (int i = 0; i < vetor.Length; i++){
    if (vetor[i] > maior){
        maior = vetor[i];
        menor = vetor[0]; // o primeiro número começa sendo o menor 
    } if (vetor[i] < menor){
        menor = vetor[i];
    }
}
Console.Write($"a soma dos valores é {soma} e o maior valor foi o {maior} e o menor valor foi o {menor}");



// Numa eleição existem três candidatos. Faça um programa que peça o número total de eleitores. peça para cada eleitor votar e ao final mostrar o número de votos de cada candidato

//int numeroCandidato01 = 14;
//int numeroCandidato02 = 55;
//int numeroCandidato03 = 33;

//int votoCandidato01 = 0, votoCandidato02 = 0 , votoCandidato03 = 0;

//Console.Write("Quantos eleitores votaram? ");
//int qtdeEleitor = int.Parse(Console.ReadLine()!);

//int[] votos = new int[qtdeEleitor];

//for (int i = 0; i < votos.Length; i++){
//    Console.Write("Digite o número do candidato:  ");
//    int votoIndividual = int.Parse(Console.ReadLine());
//    if (votoIndividual == numeroCandidato01){
//        votoCandidato01 ++;
//    } else if (votoIndividual == numeroCandidato02){
//        votoCandidato02 ++;
//    } else if (votoIndividual== numeroCandidato03){
//        votoCandidato03 ++;
//    }
//}

//Console.Write($"Ao final da votação o candidato01 ganhou {votoCandidato01} votos o candidato02 ganhou {votoCandidato02} votos e o candidato03 ganhou {votoCandidato03} votos");

