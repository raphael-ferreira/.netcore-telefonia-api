# .netcore-telefonia-api

<h3>Projeto desenvolvido em .NET Core</h3>

<h4>Conteúdo do projeto</h4>

- <b>Três classes:</b> Plano, Operadora e DDD.
- <b>Dois controllers:</b> Planos e Operadoras.
- <b>Um enum:</b> TipoPlano.
- <b>Um contexto para armazenamento dos dados:</b> TelefoniaContext.

- Adicionado classe SeedingService para popular a API, no Startup.
- Implementados métodos para consultas, e CRUD para Operadora e Planos.
- Adicionado validações para para caso adicione um Tipo fora do Enum, ou uma Operadora fora da lista.

- Exemplo do json gerado na pasta <b>"wwwroot/img/json.png"</b>.
- <b>Ferramentas utilizadas:</b> Visual Studio 2019 e Postman.

<hr>

<h4>Testes da API realizados utilizando Postman:</h4>

<h5>Método GET:</h5>

- Listagem de planos: https://localhost:44309/api/planos
- Listagem de operadoras: https://localhost:44309/api/operadoras
- Consulta de planos por código: https://localhost:44309/api/planos/7
- Consulta de planos por tipo: https://localhost:44309/api/planos/tipo/controle
- Consulta de planos por operadora: https://localhost:44309/api/planos/operadora/oi
> "7", "controle", e "oi" são passados por parâmetros. */

<h5>Métodos POST, PUT e DELETE:</h5>

- Para cadastro, atualização e remoção: https://localhost:44309/api/planos/5
> 5 é o código passado por parâmetro.

- <b>`Para rodar a API, basta abrir a solução (.sln) no visual studio e executar (Ctrl+F5) para iniciar.`</b>

<hr>
> Desenvolvido por: Raphael D. Ferreira - 29/07/2019
> Última atualização - 09/10/2019
