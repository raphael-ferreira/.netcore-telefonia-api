# .netcore-telefonia-api

<h3>API desenvolvida em .NET Core</h3>

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

- Listagem de planos: `/planos`
- Listagem de operadoras: `/operadoras`
- Consulta de planos por código: `/planos/:id`
- Consulta de planos por tipo: `/planos/tipo/:tipo`
- Consulta de planos por operadora: `/planos/operadora/:nome`

<h5>Métodos POST, PUT e DELETE:</h5>

- Para cadastro, atualização e remoção: `/planos/:id`

- <b>`Para rodar a API, basta abrir a solução (.sln) no visual studio e executar (Ctrl+F5) para iniciar.`</b>

<hr>
> Desenvolvido por: Raphael D. Ferreira
