-- criando a tabela de clientes
CREATE TABLE CLIENTE(
ID                 UNIQUEIDENTIFIER       NOT NULL,
NOME               NVARCHAR(150)          NOT NULL,
EMAIL              NVARCHAR(100)          NOT NULL UNIQUE,
SENHA              NVARCHAR(40)           NOT NULL,
DATAHORACRIACAO    DATETIME               NOT NULL,
PRIMARY KEY(ID))
GO