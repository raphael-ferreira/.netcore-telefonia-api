/**** Projeto desenvolvido em .NET Core ****/
___________________________________________________________________________

Conte�do do projeto:
- Tr�s classes: Plano, Operadora e DDD.
- Dois controllers: Planos e Operadoras.
- Um enum: TipoPlano.
- Um contexto para armazenamento dos dados: TelefoniaContext.

- Adicionado classe SeedingService para popular a API, no Startup.
- Implementados m�todos para consultas, e CRUD para Operadora e Planos.
- Adicionado valida��es para para caso adicione um Tipo fora do Enum, ou uma Operadora fora da lista.
- Exemplo do json gerado na pasta "wwwroot/img/json.png".
- Ferramentas utilizadas: Visual Studio 2019 e Postman.

___________________________________________________________________________

Testes da API realizados utilizando Postman:

M�todo GET:
- Listagem de planos: https://localhost:44309/api/planos
- Listagem de operadoras: https://localhost:44309/api/operadoras
- Consulta de planos por c�digo: https://localhost:44309/api/planos/7
- Consulta de planos por tipo: https://localhost:44309/api/planos/tipo/controle
- Consulta de planos por operadora: https://localhost:44309/api/planos/operadora/oi
/*  onde "7", "controle", e "oi" s�o passados por par�metros */

M�todos POST, PUT e DELETE:
- Para cadastro, atualiza��o e remo��o: https://localhost:44309/api/planos/5 
/* onde o 5 � o c�digo passado por par�metro */

Para rodar a API, basta abrir a solu��o (.sln) no visual studio e executar (Ctrl+F5) para iniciar.
___________________________________________________________________________

/**** Raphael D. Ferreira - 29/07/2019  ****/