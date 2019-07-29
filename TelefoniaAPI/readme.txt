/**** Projeto desenvolvido em .NET Core ****/
___________________________________________________________________________

Conteúdo do projeto:
- Três classes: Plano, Operadora e DDD.
- Dois controllers: Planos e Operadoras.
- Um enum: TipoPlano.
- Um contexto para armazenamento dos dados: TelefoniaContext.

- Adicionado classe SeedingService para popular a API, no Startup.
- Implementados métodos para consultas, e CRUD para Operadora e Planos.
- Adicionado validações para para caso adicione um Tipo fora do Enum, ou uma Operadora fora da lista.
- Exemplo do json gerado na pasta "wwwroot/img/json.png".
- Ferramentas utilizadas: Visual Studio 2019 e Postman.

___________________________________________________________________________

Testes da API realizados utilizando Postman:

Método GET:
- Listagem de planos: https://localhost:44309/api/planos
- Listagem de operadoras: https://localhost:44309/api/operadoras
- Consulta de planos por código: https://localhost:44309/api/planos/7
- Consulta de planos por tipo: https://localhost:44309/api/planos/tipo/controle
- Consulta de planos por operadora: https://localhost:44309/api/planos/operadora/oi
/*  onde "7", "controle", e "oi" são passados por parâmetros */

Métodos POST, PUT e DELETE:
- Para cadastro, atualização e remoção: https://localhost:44309/api/planos/5 
/* onde o 5 é o código passado por parâmetro */

Para rodar a API, basta abrir a solução (.sln) no visual studio e executar (Ctrl+F5) para iniciar.
___________________________________________________________________________

/**** Raphael D. Ferreira - 29/07/2019  ****/