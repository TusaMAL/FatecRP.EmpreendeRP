CREATE DATABASE EmpreendeRP
GO

USE EmpreendeRP
GO

CREATE TABLE pessoas
(
	nrcad			int				not null primary key identity,   
	edicaoempreend	varchar(5)		not null,		
	cpf				varchar(20)		unique,
	rg				varchar(20)		,
	nome			varchar(100)	not null,
	datanasc		date			not null,
	email			varchar(60),
	cep				varchar(9),
	logradouro		varchar(50)		not null,
	numero			varchar(50)		not null,
	bairro			varchar(50),
	cidade			varchar(50),
	uf				varchar(2),
	fixo			varchar(20),
	celular			varchar(20),
	escolaridade	varchar(20)		not null,
	trabalha		varchar(3)		not null,
	ondtrabalha		varchar(10),
	ehempreendedor	varchar(3)		not null,
	cnpj			varchar(18),
	necessidadeesp	varchar(3)		not null,
	qualnecessidad	varchar(50),	
	sabendoevento	varchar(20),
	outro			varchar(50)	
)
GO

CREATE TABLE admins
(
	id				int				not null primary key identity,
	login			varchar(50),
	senha			varchar(max)
)
GO

CREATE PROCEDURE cadPessoa
(
	@edicaoempreend varchar(5), @cpf varchar(20), @rg varchar(20), @nome varchar(100), @datanasc date, @email varchar(60), @cep varchar(9), @logradouro varchar(50), @numero varchar(50), @bairro varchar(50),
	@cidade varchar(50), @uf varchar(2), @fixo varchar(20), @celular varchar(20), @escolaridade varchar(20), @trabalha varchar(3), @ondtrabalha varchar(10), @ehempreendedor varchar(3),
	@cnpj varchar (18), @necessidadeesp varchar(3), @qualnecessidad varchar(50), @sabendoevento varchar(20), @outro varchar(50)
)
AS
BEGIN
	INSERT INTO pessoas values (@edicaoempreend, @cpf, @rg, @nome, @datanasc, @email, @cep, @logradouro, @numero, @bairro, @cidade, @uf, @fixo, @celular, @escolaridade,
								@trabalha, @ondtrabalha, @ehempreendedor, @cnpj, @necessidadeesp, @qualnecessidad, @sabendoevento, @outro)
END
GO

CREATE VIEW validarCPF
AS
SELECT	p.cpf	CPF
FROM	pessoas p

