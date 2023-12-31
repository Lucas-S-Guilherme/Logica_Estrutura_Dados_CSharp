Página 24
## 2.1 Definição de Algoritmo
*Algoritmo* é uma sequência lógica e finita de instruções, que devem ser seguidas para a resolução de um problema ou a execução de uma tarefa.

## 2.2 O uso dos algoritmos

## 2.3 Tipos de algoritmos

Os princiais são: descrição narrativa, diagrama Nassi-Shneiderman, pseudocódigo e fluxograma.

### 2.3.1 Descrição Narrativa
Utiliza a linguagem natural para especificar os passos da realização das tarefas. Possuí pouca formalidade e por dar margem a interpretações ambíguas, dificilmente é utilizada na representação de algoritmos.

### 2.3.2 Diagrama Nassi-Shneiderman

Também conhecido como diagrama de Chapin, apresenta a solução do problema por meio de um diagrama de quadros com uma visão hierárquica e estruturada.

### 2.3.3
*Pseudocódigo* significa falso código. utiliza linguagem estruturada e se assemelha, na forma a um programa escrito na linguagem de programação Pascal.
Também chamado de português estruturado.
A estrutura básica de um pseudocódigo compreende a identificação, a declaração de variáveis e o corpo do algoritmo.
Exemplo:

1.  Algoritmo exemplo
2.  Var
3.      a, b: inteiro
4.  Início
5.      Ler (a, b)
6.      Se (a > b) então
7.          Mostrar ("O maior valor é a", a)
8.      Senão
9.          Se (a < b) então
10.             Mostrar ("O maior valor é b", b)
11.         Senão
12.             Mostrar ("Os valores de a e b são iguais")
13.         Fim-Se
14.      Fim-Se
15. Fim

*Identificação do algoritmo*

*Declaração de variáveis*
A palavra reservada Var indica a ára para declaração das variáveis e, na linha 3, as variáveis a e b são declaradas.

*Corpo do algoritmo*
Encontramos as palavras reservadas Início e Fim, respectivamente. Estas delimitam o espaço definido para escrever todos os passos necessários para solucionar o problema:

• a entrada de valores para as variáveis;
• as operações de atribuição, lógicas e aritméticas;
• a abertura e o fechamento de arquivos;
• os laços de repetição;
• a exibição dos resultados; entre outros.

Na linha 5, a instrução Ler (a, b) indica a entrada dos dados que ficarão, temporariamente, armazenados nas variáveis a e b.
Os laços de decisão, estruturas do pseudocódigo, são iniciados com a palavra reservada
Se e finalizados com Fim-Se (linhas 13 e 14). Nas linhas 6 e 9, são realizados testes lógicos
para verificação da condição estabelecida no problema, isto é, para verificar qual variável
possui o maior valor ou se são iguais. A instrução Mostrar( ), na linha 12, é utilizada para
apresentar mensagem com o resultado das operações realizadas

### 2.3.4 Fluxograma
Um tipo de algoritmo que se utiliza de símbolos gráficos para representar ações ou instruções a serem seguidas.
Também chamado de diagrama de blocos.

## 2.4 Exercícios para fixação

**1.** Resolver um problema ou executar uma tarefa.

**2.** Aplicação: Classificação de E-mails como "Spam" ou "Não Spam"

Finalidade:
A finalidade dessa aplicação é automatizar o processo de triagem de e-mails, distinguindo entre e-mails indesejados (spam) e e-mails legítimos (não spam). Isso ajuda a manter a caixa de entrada dos usuários livre de mensagens não solicitadas, economizando tempo e melhorando a experiência do usuário.

Como os algoritmos são utilizados:

Conjunto de Treinamento: Um conjunto de treinamento é preparado, contendo exemplos de e-mails rotulados como "spam" ou "não spam".

Extração de Recursos: Algoritmos podem ser usados para extrair características relevantes dos e-mails, como palavras-chave, frequência de termos, presença de links, entre outros.

Treinamento do Modelo: Com base no conjunto de treinamento e nas características extraídas, um algoritmo de aprendizado de máquina, como o Naive Bayes, SVM (Support Vector Machine) ou outros, é treinado para classificar automaticamente os e-mails.

Classificação em Tempo Real: Uma vez treinado, o modelo pode ser aplicado em tempo real para classificar novos e-mails que chegam à caixa de entrada do usuário como "spam" ou "não spam".

Essa aplicação simples de algoritmos demonstra como a automação através de aprendizado de máquina pode ser utilizada para resolver problemas do dia a dia, melhorando a eficiência e a organização pessoal. O usuário se beneficia ao ter menos distrações na caixa de entrada, concentrando-se apenas nos e-mails importantes.

**3.** Fluxograma: utiliza de símbolos gráficos para representar ações ou instruções a serem seguidas.
Também chamado de diagrama de blocos.

**4.** As condições são avaliadas e existe uma operação para o resultado verdadei e outra para o resultado falso. Após a apresentação das mensagens, o fluxo deve seguir para o final da execução.

**5** 
a) Abrir o navegador.
b) Digitar o endereço do site do banco.
c) Digitar o nome do usuário.
d) Confirmar ou digitar o nome do usuário.
e) Preencher dados (números de agência e conta)
f) inserir a senha.
g) Clicar no botão "OK" de acesso.
h) Selecionar a opção de saldo.
i) Fechar o navegador.

**6** 
a) pegue uma lâmpada nova.
b) suba a escada.
c) retire a lâmpada velha.
d) coloque a lâmpada nova.
e) desça da escada.

**7** 
a) 2 x 4 = 8
b) -4 + 8 = 4
c) 5 + 4 = 9

**8** 
a) 2 x 4 = 8
b) -4 = 4
c) + 5 = 9

**9** 
a) 1 -> 2 -> 4 -> 7 -> 9 -> 10 -> 12 = 12.
b) 1 -> 3 -> 6 -> 8 -> 11 -> 12.

