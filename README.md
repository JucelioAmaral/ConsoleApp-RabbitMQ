
# Console Application RabbitMQ

Console application feita em .Net Core.3.1 com implementação de RabbitMQ.

## Pré requisitos
 
1. [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/)
2. [RabbitMQ e Erlang](https://chocolatey.org/install#individual)

## Como baixar o código

git clone https://github.com/JucelioAmaral/ConsoleApp-RabbitMQ.git

## Como configurar?

1. Acesso ao código: https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html
2. Instalar o pacote RabbitMQ.Client
3. Vídeo de funcionamento, instalação e configuração do Erlang e RabbitMQ do Macoratti: https://www.youtube.com/watch?v=CF63uG0rTcU
4. Instalação do Erlang e RabbitMQ, através do item 2 dos Pré requisitos (Chocolatey https://chocolatey.org/install#individual)
Comando para instalação pelo PowerShell:
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))
5. Durante a instalação do Erlang e RabbitMQ haverão perguntas que deverá responder com "y" (yes).
6. Ativando plugin: Entre na pasta "C:\Program Files\RabbitMQ Server\rabbitmq_server-3.8.19\sbin>" e insira o comando: "rabbitmq-plugins enable rabbitmq_management";
Exemplo: C:\Program Files\RabbitMQ Server\rabbitmq_server-3.8.19\sbin>rabbitmq-plugins enable rabbitmq_management
7. Acessar o RabbitMQ local: http://localhost:15672
8. Credenciais de login: Usuário e senha: guest e guest.

Vídeo com mais conteúdo de código e teste: https://www.youtube.com/watch?v=QzBvkZ4L1dg e https://blog.cedrotech.com/rabbitmq-o-que-e-e-como-utilizar

9. Executar os App's pelo Visual Studio.

## Como executar os app's?

1. OBS: Executar primeiro quem consome e depois quem publica.
2. Abrir as solution's;
3. Clicar no botão em Start.

