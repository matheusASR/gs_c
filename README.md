# GS - C
## INTEGRANTES:
MATHEUS AUGUSTO SANTOS REGO RM551466
JOÃO PEDRO DE ALBUQUERQUE OLIVEIRA RM551579 
PEDRO AUGUSTO CARNEIRO BARONE BOMFIM RM99781

# Sistema de Monitoramento Cibernético em Falhas de Energia

## Finalidade do Sistema

Sistema de console desenvolvido em C# para registrar, simular e monitorar atividades cibernéticas durante períodos de falhas de energia. 
Ideal para estudos de segurança da informação e tratamento de incidentes.

---

## Instruções de Execução

1. **Clone o repositório ou baixe os arquivos.**
2. **Abra a solução em uma IDE como Visual Studio ou Visual Studio Code.**
3. Compile e execute o arquivo `Program.cs`.

```bash
dotnet build
dotnet run
```

> Certifique-se de que você está no diretório correto e que o SDK do .NET está instalado.

---

## Dependências

- .NET SDK 6.0 ou superior
- Nenhuma dependência externa adicional

---

## Estrutura de Pastas

```
SistemaCiberEnergia/
├── Program.cs                     # Ponto de entrada do sistema
├── Models/
│   └── Usuario.cs                # Representação do modelo de usuário
└── Services/
    ├── Autenticador.cs           # Classe de autenticação de usuários
    └── Monitoramento.cs          # Registro de atividades e simulações de erro
```

---

## Funcionalidades

### 1. Autenticação com validação de senha
Permite login apenas se usuário e senha estiverem corretos.
Exibe "Usuário não encontrado" ou "Senha incorreta" com base na situação.

### 2. Simulação de erro com entrada de data
O usuário informa uma data e o sistema valida se é uma data válida.
Em caso de erro, registra no log.

### 3. Relato de ocorrência com base em uma data
Permite que o usuário descreva o que aconteceu na data simulada.

### 4. Geração de alerta de segurança
Gera um alerta automaticamente se o usuário for admin.

### 5. Verificação condicional de falhas em serviços
Pergunta se houve falha em algum serviço e só executa o registro se o usuário disser que sim.

### 6. Registro do serviço que falhou
Se o usuário disser que houve falha, ele informa o nome do serviço (ex: DNS), e isso é registrado.

### 7. Classificação da atividade como "normal" ou "anormal"
O sistema analisa o texto do relato e identifica palavras críticas.
Registra no log se a atividade foi normal ou anormal.

### 8. Geração de relatório final
Consolida as ações e registra o total de logs até o momento.

### 9. Sistema de logs interno
Todas as ações relevantes do sistema são registradas em memória e exibidas ao final.
