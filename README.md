# Gabriel-Works
 Benchmark de Algoritmos de Ordenação

## Sobre o Projeto
Este projeto foi desenvolvido como parte de uma atividade acadêmica com o objetivo de implementar e analisar algoritmos de ordenação utilizando a linguagem C# e a plataforma .NET.
A proposta consiste na criação de um sistema capaz de executar diferentes algoritmos de ordenação, medir seu desempenho e apresentar resultados que permitam a comparação entre teoria e prática.

## Objetivo

O principal objetivo do projeto é:
- Implementar algoritmos clássicos de ordenação
- Avaliar o desempenho em diferentes cenários
- Comparar os resultados obtidos com a complexidade teórica
- Desenvolver uma análise prática sobre tempo de execução e comportamento dos algoritmos

## Funcionalidades
O sistema permite:
- Escolher o algoritmo de ordenação:
- QuickSort
- MergeSort (ou BubbleSort, dependendo da versão)
- Inserir manualmente os valores do vetor
- Executar o algoritmo múltiplas vezes para obter dados mais consistentes
- Exibir:
  - Tempo total de execução
  - Uso de CPU (%)
  - Uso de memória RAM (bytes)
  - Vetor ordenado

## Algoritmos Utilizados
- QuickSort
Algoritmo eficiente baseado em divisão e conquista, com complexidade média de *O(n log n)*.
- MergeSort
Algoritmo estável que utiliza divisão e conquista, também com complexidade *O(n log n)*.
- BubbleSort (caso incluído)
Algoritmo simples de comparação, com complexidade *O(n²)*.

## Metodologia
O programa executa os algoritmos várias vezes (loop de repetições) para garantir medições mais precisas.
Além disso, são utilizados dois tipos de vetores:
- Vetor normal (3 posições)
- Vetor estendido (5 posições)
Os dados são coletados e exibidos ao usuário para análise posterior.

## Tecnologias Utilizadas
- C#
- .NET
- Console Application

## Resultados Esperados
Espera-se que algoritmos mais eficientes, como QuickSort e MergeSort, apresentem melhor desempenho em comparação com algoritmos mais simples, como BubbleSort.
