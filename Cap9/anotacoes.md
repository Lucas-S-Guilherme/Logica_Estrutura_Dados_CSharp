# Recursividade

Propriedade daquilo que se pode repetir
um número indefinido de vezes.

Um objeto é dito recursivo
se ele consistir parcialmente ou for definido em termos de si próprio.

Um algoritmo recursivo é uma função que possui chamadas, a si mesmo, para a
resolução de um problema, tendo como princípio a sua divisão em partes menores.

Para isso, deve-se considerar:

• Se o problema em questão é pequeno, então, deve ser resolvido diretamente.

• Senão, deve ser reduzido a um problema menor, da mesma natureza, aplicando-
-se este método sucessivas vezes, até a solução completa.

É importante lembrar que uma função recursiva possui duas partes:

• Caso base: tratamento dado às situações simples, isto é, quando não há necessidade de recursão, garantindo a condição de saída da função.

• Caso recursivo: situação em que há necessidade de uma chamada a si mesmo.

EXEMPLO 9.1

Calcule o fatorial de um número n qualquer.

Sabendo que o fatorial de um número n pode ser definido como n! = n * (n — 1)!,
resolvemos o problema utilizando uma função recursiva, considerando as seguintes regras:

• Se n = 0, então n! = 1. Este é o caso base; observe que, se o valor de n é igual a zero,
sabe-se que o resultado é 1.

• Se n > 0, então n 1 = n (n — 1) 1 Este é o caso recursivo ou geral; será chamado
n vezes até que o problema seja reduzido ao caso base.

**Pseudocódigo:**

```
1. Função Fatorial (n: inteiro): inteiro
2. Var
3. fat: inteiro
4. Início
5. fat - 1
6. Se (n = 0) então
7. Retornar fat
8. Senão
9. fat - n * Fatorial(n — 1)
10. Fim-Se
11. Fim Fatorial.
```

Na linha 6, apresenta-se o caso base, que também é a
condição de saída e, caso seja satisfeita, retorna o valor armazenado na variável fat (linha 7).
Havendo necessidade de reduzir o problema, isto é, não tendo sido realizada a operação prevista no caso base, então aplica-se a recursividade (linha 9).

## 9.2 Recursividade de Cauda

É o modo mais simples de recursividade, pois utiliza apenas uma chamada recursiva,
que ocorre após todas as instruções da função. A recursividade de cauda muitas vezes pode ser substituída por uma solução iterativa, considerando a repetição, até que a condição de saída seja satisfeita.

**EXEMPLO 9.2**

Criar uma função que, a partir de um número n, calcule a soma dos elementos do conjunto formado pelos números de zero até n.

Pseudocódigo:
```
1. Função Soma (n: inteiro): inteiro
2. Início
3.      Se (n = 1) então
4.          Retornar (1)
5.      Senão
6.          Retornar (n + Soma (n - 1))
7.      Fim-Se
8. Fim Soma
```

Na linha 1, é identificada a função Soma, que recebe como parâmetro um valor que será armazenado na variável n; esta função deve retornar um inteiro.

A recursividade é a última operação da função Soma e, por isso, podemos defini-la
como recursividade de cauda.

## 9.3 Riscos da Recursividade

A recursividade possibilita a escrita de um código mais enxuto, com maior legibilidade e simplicidade, porém oferece alguns riscos que devem ser considerados:

• O tempo para execução do algoritmo pode ser maior do que o tempo para execução
de uma solução não recursiva.

• Em tempo de execução, os dados são armazenados em uma pilha e, dependendo da
quantidade de chamadas recursivas, o tamanho da pilha pode ser excedido.



### 9.3.1 ANÁLISE DO ALGORITMO RECURSIVO

Analisando o algoritmo que utiliza a recursividade, em relação ao não recursivo, podemos observar que:

• A solução recursiva é mais enxuta que a iterativa.

• Para cada termo que precisa ser gerado, o algoritmo recursivo realiza duas chamadas também recursivas.

• O custo de processamento é maior, em função do número de chamadas à mesma
função. Por exemplo, considerando o cálculo do quarto termo da sequência, são
necessárias quatro chamadas recursivas.