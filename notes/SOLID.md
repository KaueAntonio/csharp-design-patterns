# SOLID

## S: SRP - Single Responsibility Principle:

Princípio da Responsabilidade Única.

 - Uma classe deve ter um, e somente um, motivo para mudar.
 - SRP nao é apenas para classes, mas sim para procedimentos, funcoes etc.

##### Cuidado com as "God Classes - Classe Deus":
Em sistemas legados é muito comum ver classes que fazem de tudo.


## O: OCP - Open-Closed Principle:

Princípio Aberto-Fechado.

 - Objetos ou entidades devem estar abertos para extensao, mas fechados para modificacao.
  - Quando novos comportamentos e recursos precisam ser adicionados no software, devem estender e nao alterar o código fonte original.


## L: LSP - Liskov Substitution Principle
Princípio da substituicao de Liskov.

 - Uma classe derivada deve ser substituivel por sua classe base.
 - Quando voce implementar uma herança, ela deve ser desenvolvida de modo que, se voce precisar substituir o objeto da sua classe derivada, o sistema deveria continuar funcionando com uma instancia da classe base sem efeitos colaterais.

##### Imagine um retangulo e um quadrado:
Os quadriláteros que possuem todos os angulos retos sao chamados de retangulos. Sendo assim, todo quadrado é também um retangulo, pois, todo quadrado possui todos os angulos retos, mas nem todo retangulo possui os quatro lados congruentes.


## I: ISP - Interface Segregation Principle:
Princípio da Segregaçao da Interface.

 - Uma classe nao deve ser forçada a implementar interfaces e métodos que nao irao utilizar.

## I: DIP - Dependency Inversion Principle:
Princípio da Inversao de Dependencia.
 - Dependa de abstraçoes e nao de implementaçoes.