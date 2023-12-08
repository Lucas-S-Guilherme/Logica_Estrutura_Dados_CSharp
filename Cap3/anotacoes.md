# Conceitos Básicos sobre algoritmos

## 3.1 Definição de dados

*Dado* é uma sequência de símbolos quantificados ou quantificáveis.
O estudo dos algorimos tem como base os dados, pois, para que ocorra a resolução de um problema, faz-se necessária a escolha da representação da realidade, geralmente definida em termos de dados e suas representações.

## 3.1 Tipos de dados

Definir o tipo de dado mais adequado para ser armazenado em uma variável é importante para garantir a resolução do problema.

### 3.2.1

São grupos de valores indivisíveis, como os tipos literal, inteiro, real e lógico, utilizados na construção de algoritmos, cujos equivalentes, em C# são string, int, float ou double e bool, entre outros.

Em C#, os tipos primitivos de dados básicos incluem:

**Inteiros:**
byte: 8 bits, sem sinal, varia de 0 a 255.
sbyte: 8 bits, com sinal, varia de -128 a 127.
short: 16 bits, com sinal, varia de -32,768 a 32,767.
ushort: 16 bits, sem sinal, varia de 0 a 65,535.
int: 32 bits, com sinal, varia de -2.147.483.648 a 2.147.483.647.
uint: 32 bits, sem sinal, varia de 0 a 4.294.967.295.
long: 64 bits, com sinal, varia de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807.
ulong: 64 bits, sem sinal, varia de 0 a 18.446.744.073.709.551.615.

**Ponto Flutuante ou real:**
float: 32 bits, representação de ponto flutuante de precisão simples.
double: 64 bits, representação de ponto flutuante de precisão dupla.
decimal: 128 bits, usado para valores monetários e outros cálculos que requerem alta precisão.

Caracteres:
char: 16 bits, representa um caractere Unicode, Ex: char = 'A'.

Booleano:
bool: Representa um valor booleano, true ou false.

Cadeia de Caracteres:
string: Representa uma sequência de caracteres.

void: Representa a ausência de tipo. Usado principalmente como retorno de métodos que não retornam valores.
Esses são os principais tipos primitivos de dados em C#. Além disso, C# também suporta tipos derivados e personalizados.

Essa é a declaração de uma variável em C#:

int n = 4;

Em C# a declaração de uma variável é da seguinte maneira: definição de um tipo(int), um nome para a variável(n), símbolo de atribuição (=) e do valor que a variável (n) irá assumir(4), fechando a declaração com ;.

### 3.2.2 Tipos Construídos

Nos algoritmos, assim como nas linguagens de programação, existe a possibilidade de
criarmos outros tipos de dados, chamados tipos construídos, obtidos pela combinação de
alguns tipos, inclusive os primitivos. O tipo construído mais comum consiste na declaração
de um conjunto de campos que compõe um registro. Por exemplo:

```
Algoritmo Exemplo_Registro
Var
    Tipo reg_paciente = registro
        nome: literal
        idade: inteiro
        peso: real
        fim_registro
        paciente: reg_paciente
    ...
```
Em C#, um registro corresponde a uma classe geralmente composta por vários campos (atributos).

## 3.2 Variáveis
Uma variável pode ser entendida como uma posição de armazenamento que contém dados que podem ser modificados durante a execução do pragrama, podendo assumir qualquer um dos valores de um conjunto de valores.

As variáveis armazenam dados temporariamente, são utilizadas para representar valores desconhecidos, que podem ser alterados de acordo com a situação.

### 3.3.1 Identificação das variáveis para os algoritmos

Regras:
    Não utilizar espaços entre as letras.
    Não iniciar o nome da variável com algarismos.
    Não utilizar palavras reservadas.
    Não utilizar caracteres especiais.
    Em c#, usa-se a convensão de nomenclatura camel case, onde cada palavra adicional começa em maiúscula, com exceção da primeira.

### 3.3.2 Identificadores de variáveis para a linguagem C#

## 3.4 Constantes
São valores que não sofrem alterações ao longo do desenvolvimento do algoritmo ou da execução do programa.

Em C# declaramos uma constante com a palavra-chave *const* antes do tipo. Ex: const int n = 5;

Também são chamadas de *variáveis somente de leitura*

## 3.5 Operadores
Utilizados para representar expressões de cálculo, comparação, condição e atribuição.


