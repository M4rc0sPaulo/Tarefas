IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Anotacoes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Data] datetime2 NOT NULL,
    [IdPrioridade] int NOT NULL,
    [Tipo] nvarchar(max) NOT NULL,
    [Descricao] nvarchar(max) NULL,
    CONSTRAINT [PK_Anotacoes] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'Descricao', N'IdPrioridade', N'Nome', N'Tipo') AND [object_id] = OBJECT_ID(N'[Anotacoes]'))
    SET IDENTITY_INSERT [Anotacoes] ON;
INSERT INTO [Anotacoes] ([Id], [Data], [Descricao], [IdPrioridade], [Nome], [Tipo])
VALUES (1, '2023-06-25T01:00:00.0000000', N'Refazer atividade pendente do dia 19/05. Continuar a sua escrita normalmente', 2, N'Refazer Atividade', N'Trabalho'),
(2, '2023-06-30T01:00:00.0000000', N'Mestrar uma mesa de RPG chamada Reflexo do Outro Lado. Preparar tudo que precisa ser feito como músicas, tokens e mapas  ', 1, N'Mestrar RPG Ordem', N'Atividade'),
(3, '2023-07-10T01:00:00.0000000', N'Continuar Atividade de Banco de Dados do dia 13/06', 1, N'Continuar Banco', N'Escola'),
(4, '2023-06-27T01:00:00.0000000', N'Dentista marcado as 17:30', 2, N'Dentista', N'Saúde');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Data', N'Descricao', N'IdPrioridade', N'Nome', N'Tipo') AND [object_id] = OBJECT_ID(N'[Anotacoes]'))
    SET IDENTITY_INSERT [Anotacoes] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230621011752_InitialCreate', N'7.0.7');
GO

COMMIT;
GO

