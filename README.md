# LocadoraMVC

Antes de iniciarmos, precisamos que seja alterado a instancia do SQL e tambem feita a migração das tabelas. Abaixo, passo a passo para a execução correta desses passos

1°Passo 
 </br>
  Acessar o appsettings do projeto loc-application e alterar a DefataulConnection para o banco de dados na sua maquina
  ![image](https://user-images.githubusercontent.com/79101662/191064977-58a1d98e-a9fe-47b4-9b4d-1ce44c642df6.png)

2°Passo 
  </br>
  Executar o update migration, para criação das tabelas e inserção dos dados no SQL
  </br>
      - Em Ferramentas(Tools) - Gerenciador de Pacotes Nuget(Package Source Nuget) - Console do Gerenciador de Pacotes
 </br>
      - Ao abrir o console executar o seguinte comando
  </br>
          - update-database
  ![image](https://user-images.githubusercontent.com/79101662/191066168-111b1a2f-b898-4475-9b0d-806aa91775b3.png)

  
