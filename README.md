# Robo Tupiniquim

Um projeto desenvolvido em C# para a AEB (Agência Espacial Brasileira).  
Contém um sistema poderoso capaz de fazer lançamentos de dois robôs para realizar uma pesquisa em uma determinada área de Marte.  
O programa é capaz de guiar os robôs, com comandos de movimentos e direções para quais eles devem se mover.

![](https://i.imgur.com/VDqeqBr.gif)

## Diagrama do Projeto
Planejamento do projeto feito via Whimsical:
[Trabalho - Robô Tupiniquim](https://whimsical.com/trabalho-robo-tupiniquim-NNPupydwS8aSbkpcVtG84r)

## Estrutura do Projeto

O projeto está organizado na seguinte forma:

- **[Program.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Program.cs)**: Arquivo principal, nele contém o necessário para inicializar e executar o programa.
- **[Entities/](https://github.com/gsvsantos/RoboTupiniquim/tree/master/RoboTupiniquim/Entities)**
  - **[Area.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Area.cs)**: Contém a lógica da área de pesquisa por onde os Robôs se movimentam.
  - **[Entity.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Entity.cs)**: Contém as propriedades básicas dos Robôs.
  - **[Robot.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Robot.cs)**: Lida com a lógica e comportamento dos Robôs.
- **[Entities/Utils/](https://github.com/gsvsantos/RoboTupiniquim/tree/master/RoboTupiniquim/Entities/Utils)**
  - **[Validators.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Utils/Validators.cs)**: Contém funções para validar entradas e dados.
  - **[ViewColors.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Utils/ViewColors.cs)**: Define as cores usadas no programa para exibição de mensagens.
  - **[ViewUtils.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Utils/ViewUtils.cs)**: Contém funções interativas com o usuário.
  - **[ViewWrite.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Utils/ViewWrite.cs)**: Responsável pela escrita de mensagens no console.
  - **[ViewWriteErrors.cs](https://github.com/gsvsantos/RoboTupiniquim/blob/master/RoboTupiniquim/Entities/Utils/ViewWriteErrors.cs)**: Responsável pela escrita de mensagens de erro no console.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
 
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,visualstudio,cs,dotnet)](https://skillicons.dev)

## Como Utilizar
1. **Clone o Repositório:**
```
git clone https://github.com/gsvsantos/RoboTupiniquim.git
```

2. Abra o terminal ou prompt de comando e navegue até a pasta raiz do programa.

3. Utilize o comando abaixo para restaurar as dependências do projeto.
```
dotnet restore
```

4. Compile e execute o arquivo *.exe* do programa.
```
dotnet build --configuration Release
```
```
RoboTupiniquim.exe
```

### Opcional
- Executar o projeto compilando em tempo real
```
dotnet run --project RoboTupiniquim
```

# Sobre o Projeto

Este projeto foi desenvolvido como parte de um trabalho da [Academia do Programador](https://www.instagram.com/academiadoprogramador/).
