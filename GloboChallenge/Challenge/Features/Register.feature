#language: pt-BR

@Chrome
Funcionalidade: Register

Narrativa:
	Eu como usuario do sistema
	Quero fazer um novo cadastro
	Para ter acesso a todos os recursos do sistema


Cenario: 1 - Criar Novo Cadastro
	Dado que eu navegue para a tela Home
	Quando clico em Novo Cadastro
	E preencho os dados
	Entao vejo a mensagem de cadastrado com sucesso

Cenario: 2 - Erro ao Criar Novo Cadastro
	Dado que eu navegue para a tela Home
	Quando clico em Novo Cadastro
	E preencho os dados
	Entao vejo a mensagem de que não foi possível se cadastrar com sucesso