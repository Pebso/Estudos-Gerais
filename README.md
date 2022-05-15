# Estudos gerais em C#

*int* serve para indicar numeros inteiros.



double* para declarar uma variável como sendo um número de ponto flutuante.

**exemplo de codigo com numero inteiro**

    int x,y;

            x = 5;
            
            y = 2 * x;

            console.whriteline(x);
            console.whriteline(y);

            console.readline ();
            
            gerando os resultados 5 e 10.
            
mas caso tivessemos que gerar uma resultado com ponto flutuante, acrescnetaria o double. 
**EX**

    int a,b;

       double resultado;


        a = 5;

        
        b = 2;

        resultado = (double) a / b;

        console.whriteline(resultado);

        console.readline ();


para o meu resultado dar 2,5 eu tenho que fazer esse *casting* colocalndo  " (double)" para o meu compilador reconhecer o resultado da expressão.


## Aula sobre entrada de dados em C#
Entrada de dados é quando o programa vai ler os dados que o usuario digitar, ou, quando o programa vai ler o dado de outra fonte. 

O comando em C# para ler os dados a partir do teclado, é o comando " Console.Readline () ". Ele lê da entrada padrão até a quebra de linha, e volta os dados lidos na forma de *_string_. Quebra de linha é quando o usuário digita a tecla enter.

*_string_  são cadeias de caracteres que armazenam dados textuais.

#### Diferença entre string e char em C#:
**String** é uma sequência de caracteres enquanto um **char** representa um único caractere.
[] representa vetor
# Exercicio
Objetivos: 

* Ler um texto até a quebra de linha e armazenar em uma variável
* Ler três palavras, uma em cada linha, armazenando cada uma em uma variavel
* Ler três palavras na mesma linha, separando por espaço, armazenando cada uma em uma variável

Código do exercicio 1 feito


                 string frase = Console.ReadLine();
                 string x = Console.ReadLine();
                 string y = Console.ReadLine();
                 string z = Console.ReadLine();

                 string s = Console.ReadLine();

                 string[] vet = s.Split(' ');

                 string a = vet[0];
                 string b = vet[1];
                 string c = vet[2];
 



                 Console.WriteLine("Você digitou");
                 Console.WriteLine(frase);
                 Console.WriteLine(x);
                 Console.WriteLine(y);   
                 Console.WriteLine(z);
                 Console.WriteLine(a);
                 Console.WriteLine(b);
                 Console.WriteLine(c);

------------------------------------ 
# Exercicio 2 C#

Antes de qualquer coisa, este exercicio foi meu primeiro codigo sem colar, por mais simples que seja fico feliz em ver minha propria evolução!

O objetivo do exercicio era 
* Ler um numero inteiro 
* Ler um caractere
* Ler um numero double
* Ler um nome (unica palavra), sexo( caractere F ou M), idade (inteiro e altura (double) na mesma linha, armazinando-os em quatro variaveis com os devidos tipos.

São eles: 

n1=35 

ch=f 

n2=4,32

nome =maria    sexo =f   idade =23 altura =1,68

Bom, primeiro eu codei tudo com o comando **Console.Readline**, separei os espaços com vetores certinho, só que ainda ficava dando erro. Por que? Porque o **Console.Readline** lê a informação em forma de string, ou seja no **n1** ele estaria interpretando como um texto **3 5** e nao um inteiro **35**. Então eu faço uma conversão de tipos, de string para inteiro, então eu uso o comando **int.Parse**. 

 _Parse_ = analisar.

Usei o mesmo conceito para totodos os outros, sendo **double** **char** ou **int**.

ps: erros de digitação podem quebrar o programa, mas até então o tratamento desse problema não era o intuito do exercicio. 


    Console.WriteLine("Bom dia!");

    string frase = Console.ReadLine();

    int n1 = int.Parse (Console.ReadLine());
    char ch = char.Parse (Console.ReadLine());
    double n2 = double.Parse (Console.ReadLine());

    string s = Console.ReadLine();

    string[] vet = s.Split(' ');

    string nome = vet[0];
    char sexo = char.Parse (vet[1]);
    int idade = int.Parse (vet[2]);
    double altura = double.Parse (vet[3]);

    double valor1 = 0;
    double valor2 = 0;


    Console.WriteLine("Você digitou");
    Console.WriteLine(frase);
    Console.WriteLine(n1);
    Console.WriteLine(ch);
    Console.WriteLine(n2);
    Console.WriteLine(nome);
    Console.WriteLine(sexo);
    Console.WriteLine(idade);
    Console.WriteLine(altura);



 # Exercicio 3 C#

### Objetivo do exercício:

![imagem exercicio](https://i.ibb.co/1QTWMs5/exercicio-3.jpg)


### Primeiro eu fiz o exercicio como pediu, e depois eu fiz um "extra" formatando o código para interação direta com o usuário. Pode até estar errado, mas foi assim que eu fiz...

## Código do exercicio 

    Console.WriteLine("Bom Dia!");
    string a = Console.ReadLine();
    int b = int.Parse (Console.ReadLine());
    string c = (Console.ReadLine());

    string s = Console.ReadLine();

    string[] vet = s.Split(' ');

    string nome = vet[0];
    int  idade = int.Parse (vet[1]);
    double altura = double.Parse (vet[2]);

    Console.WriteLine("Você digitou");
    Console.WriteLine(a);   
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(nome);
    Console.WriteLine(idade);
    Console.WriteLine(altura);

## Código do exercicio formatado, de forma que as perguntas aparecem na tela para o usuário responder.

    Console.WriteLine("Bom Dia!");
    Console.WriteLine("Nome completo");
    string a = Console.ReadLine();
    Console.WriteLine("Quantos quartos tem na sua casa?");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Preço de um produto que comprou recentemente:");
    string c = (Console.ReadLine());
    Console.WriteLine("Entre seu ultimo nome, idade e altura");
    string s = Console.ReadLine();

    string[] vet = s.Split(' ');

    string nome = vet[0];
    int idade = int.Parse(vet[1]);
    double altura = double.Parse(vet[2]);

# Exercicio 4 C# Programa para Calculo de Área e Valor de terrenos

Fazer um programa para ler as medidas da largura e o comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais.

    using System.Globalization;
    Console.WriteLine("Pressione ENTER para iniciar");
    double largura, comprimento, precoMetroQuadrado, area, preco;
    Console.ReadLine();
    Console.WriteLine("Largura");
    largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("comprimento");
    comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Preço do Metro Quadrado");
    precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Resultado:");
    area = largura * comprimento;
    preco = area * precoMetroQuadrado;
    Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));

# Funções Matemáticas em C#
###   **Exemlpo**------- ------- **Significado**
 A = Math.sqrt(x);  Váriavel A recebe a raiz quadrada de x

 A = Math.pow(x,y); Variavel A recebe o resultado de x elevado a y

 A = Math.Abs(x);   Variavel A recebe o valor absoluto de x

* sqrt - raiz quadrada
* pow  - potencialização
* abs  - valor absoluto (sem sinal)

* "F2" significa que serão impressar duas casas após o. "F3" três casas etc...
* using System.Globalization para o programar ler . e , 

# Exercicios de fixação C#
## 1. Calculando área de um circulo 

 ### A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
  
    using System.Globalization;
    Console.ReadLine();
    double r, A, pi = 3.14159;
    r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    A = pi * r * r;
    Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
A = pi * r * r representa,  area = pi . raio2.


### 2. Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável.

    Console.ReadLine();
    int A, B, SOMA;
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    SOMA = A + B;
    Console.WriteLine("Soma =" + SOMA);


### 3. Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente. 

    Console.ReadLine();
    int A, B, PROD;
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine ());
    PROD = A * B;
    Console.WriteLine("PROD =" + PROD);


### 4. Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

    using System;
    using System.Globalization;


    Console.ReadLine();
    double A, B, MEDIA;
    A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

    Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

  Aqui eu represento a expressão de média
  ## ex: a = 5,0 e b = 7,1  
   MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

   5,0 * 3,5 = 17,5
   
   7,1 * 7,5 = 53,25

Somo os valores e divido por 11. 11 é a soma dos pesos 7,5 e 3,5.

# Média ponderada
### 5. Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

    Console.ReadLine();
    int A, B, C, D, DIFERENCA, proda, prodb;
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    C = int.Parse(Console.ReadLine());
    D = int.Parse(Console.ReadLine());
    proda = A * B;
    prodb = C * D;
    DIFERENCA = proda - prodb;
    Console.WriteLine("DIFERENCA = " + DIFERENCA);
    Console.ReadLine();

# Média ponderada
### 6.Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

**Entrada**
O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

**Saída**
Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.


    using System.Globalization;
    Console.ReadLine();
    int numero, horas;
    double valor, salar;
    numero = int.Parse(Console.ReadLine());
    horas = int.Parse(Console.ReadLine());
    valor  =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    salar = horas * valor;
    Console.ReadLine();
    Console.WriteLine("NUMERO  = " + numero);
    Console.WriteLine("Salario = R$ " + salar.ToString("F2", CultureInfo.InvariantCulture));


 
 ### Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

    using System.Globalization;
    int codigo, numero, codigo2, numero2;
    double valor, valor2, preco, preco2, vp;
    codigo = int.Parse(Console.ReadLine());
    numero = int.Parse(Console.ReadLine());
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
    codigo2 = int.Parse(Console.ReadLine());
    numero2 = int.Parse(Console.ReadLine());
    valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    preco = valor * numero;
    preco2 = valor2 * numero2;
    vp = preco + preco2;
    Console.WriteLine("VALOR A PAGAR: R$ " + vp.ToString("F2", CultureInfo.InvariantCulture));
    Console.ReadLine();

# Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).
**Entrada**
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

**Saída**
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".   

    using System.Globalization;
    Console.ReadLine();
    int X;
    double Y, combustivel, combreal;
    X = int.Parse(Console.ReadLine());
    Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    combustivel = X / Y;
    combreal = Math.Abs(combustivel);
    Console.WriteLine(combreal.ToString("F3") + " km/l");

 Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade constante de 60 Km/h e o carro Y sai com velocidade constante de 90 Km/h. 
 
 Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, consegue se afastar um quilômetro a cada 2 minutos.

Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o carro Y tomar essa distância do outro carro.

**Entrada**

O arquivo de entrada contém um número inteiro.

**Saída**

Imprima o tempo necessário seguido da mensagem "minutos".
    
    