# Estudos gerais
github, C#, Markdown, html, javascript...
# **Mdown**
titutulos são impressos com " # " sendo de 1 a 6 " # ".
**ex** 
# titulo
## titulo
### titulo
#### titulo
##### titulo
###### titulo

para representar alguma palavra ou frase em negrito, basta colocar dois " * * " antes e dois depois da palavra.

## **ex**

**exemplo**

**frase totalmente em negrito para exemplo**

para colocar em italico o conceito é o mesmo, más coloca-se apensa 1 " * ".

**ex**

*exemplo* 

*frase completa em italico para exemplo*

### **Como colocar imagem**

abre [ e entre eles o nome que quer dar, depois abre ( e coloca o endereço da imagem
###  **Ex:**
 ![Pc Gamer](https://conteudo.imguol.com.br/c/entretenimento/95/2021/02/25/alguns-itens-sao-indispensaveis-para-montar-o-seu-pc-gamer-1614232957829_v2_4x3.jpg)
 
 ### **Anotações**
Usando no VsCode. Powershell, e cmd, abrem comandos. O cmd abre apenas comandos da microsoft, o powershell abre 
comando powershell ls
comando cms dir( de diretorio)
comando cd(mudar de diretorio)
comando cls (limpa a tela)

# **c#**
*int* para indicar numeros inteiros

*double* para declarar uma variável como sendo um número de ponto flutuante

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

Código do exercicio feito


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

