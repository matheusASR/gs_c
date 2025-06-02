
# Sistema de Monitoramento Cibernético em Falhas de Energia

## Finalidade do Sistema

Este projeto tem como objetivo detectar e registrar atividades suspeitas ou anomalias que possam ocorrer durante ou após falhas de energia, um momento em que sistemas ficam vulneráveis a ataques cibernéticos. 

O sistema permite autenticação de usuários, simula entradas inválidas para teste de robustez, e registra logs de atividades com clareza e organização. Ele é voltado para ambientes de pequeno e médio porte, como clínicas, escritórios, escolas e pequenas empresas.

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

- Login obrigatório com validação de credenciais
- Registro de logs de atividades
- Simulação de entradas inválidas com tratamento de exceções
- Estrutura orientada a objetos com boas práticas
