# Tutorial 

https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio

# Executar o mesmo Projeto no Linux(Ubuntu) Com Wsl, exatamente como foi criado no windows.

# Erros ao clonar e abrir o projeto no Linux
1. Execute qualquer comando no git, e será exibido a configuração para executar e corrigir.
2. Nas notificações do VS Code Clique em Restore na notificação de resolução de dependencias da Extenção C#
3. Terá outra notificação com a opção reload e clique na mesma.

**Obs: As Referencias do EntityFrameworkCore serão corrigidas**

# Instalação dos sdks caso ainda não tenha sido instalado no ubuntu
1. Acesse https://learn.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu.
2. Verifique a versão no ubuntu:
```
lsb_release -a
```
3. Identifique na doc qual versão e execute os comandos descritos para instalação dos sdks dotnet na versão desejada.
4. Digite os comandos para executar a api.
```
dotnet build
```
```
dotnet run --project TutoWebApiVsStudio
```
**Atenção:** Como Esse projeto foi criado pelo Visual Studio, somente **dotnet run** pode gerar erros, por isso deve ser executado com --project nameProject

5. Será exibido a url configurada no arquivo /Properties/launchSettings.json onde é definido o profile do projeto.

**Obs: Pelo ubuntu a execução não obtem sucesso ao pressionar Ctrl+F5**

# Testando execução local do projeto em Container Docker Desktop.
1. Acessar https://code.visualstudio.com/docs/containers/quickstart-aspnet-core#_test-the-service-container
2. Seguir o tutorial.

**Obs: É necessário instalar o docker desktop para este tutorial, vale ressaltar que os testes foram feitos com o projeto no ubuntu WSL**
**Outro detalhe, o swagger não foi possível acessar com este teste, porém ao executar com o comando run normal, o projeto executa normalmente mesmo com as inclusões de novos arquivos para execução no container**
