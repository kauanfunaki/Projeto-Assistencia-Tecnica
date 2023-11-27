create database DB;
go
use DB;

create table enderecos (
	id int identity primary key,
	rua varchar(255) not null,
	numero int not null,
	bairro varchar(255) not null,
	cidade varchar(255) not null,
	estado varchar(255) not null,
	pais varchar(255) not null,
	cep varchar(255) not null
);

create table clientes (
	id int identity primary key,
	usuario varchar(255) unique not null,
	senha varchar(255) not null,
	email varchar(255) unique not null,

	nome_completo varchar(255),
	telefone varchar(255),
	cpf varchar(255),
	endereco_id int,
	criacao_data date default getdate()

	foreign key (endereco_id) references enderecos(id)
)

create table funcionarios (
	id int identity primary key,
	nome_completo varchar(255) not null,
	cpf varchar(255) unique not null,
	telefone varchar(255),
	nascimento_data date not null,
	efetivacao_data date default getdate(),
	saida_data date
);

create table produtos (
	id int identity primary key,
	nome varchar(255) not null,
	quantidade int not null,
	preco money not null,
	categoria varchar(255),
	descricao varchar(255),
	situacao varchar(255) check (situacao in ('ativo', 'inativo')) default 'ativo' 
);

create table servicos (
	id int identity primary key,
	nome varchar(255) not null,
	preco money not null,
	categoria varchar(255),
	descricao varchar(255),
	situacao varchar(255) check (situacao in ('ativo', 'inativo')) default 'ativo'
);

create table carrinho (
	id int identity primary key,
	produto_id int ,
	servico_id int ,
	cliente_id int not null,
	quantidade int default 1 not null,
	preco_total money
);

INSERT INTO enderecos (rua, numero, bairro, cidade, estado, pais, cep)
VALUES 
('Rua da Praia', 100, 'Centro', 'Rio de Janeiro', 'Rio de Janeiro', 'Brasil', '20010-000'),
('Avenida Paulista', 1234, 'Bela Vista', 'São Paulo', 'São Paulo', 'Brasil', '01310-100'),
('Rua das Flores', 500, 'Jardim das Flores', 'Curitiba', 'Paraná', 'Brasil', '80020-060'),
('Avenida Brasil', 700, 'Boa Vista', 'Porto Alegre', 'Rio Grande do Sul', 'Brasil', '90050-001'),
('Rua das Palmeiras', 300, 'Jardim Botânico', 'Goiânia', 'Goiás', 'Brasil', '74605-140'),
('Rua da Lagoa', 800, 'Centro', 'Fortaleza', 'Ceará', 'Brasil', '60060-180'),
('Avenida Central', 1500, 'Centro', 'Belo Horizonte', 'Minas Gerais', 'Brasil', '30170-120'),
('Rua das Dunas', 200, 'Praia de Iracema', 'Fortaleza', 'Ceará', 'Brasil', '60060-170'),
('Avenida Beira Mar', 1800, 'Praia de Iracema', 'Fortaleza', 'Ceará', 'Brasil', '60060-150'),
('Rua da Garoa', 450, 'Jardim América', 'São Paulo', 'São Paulo', 'Brasil', '01449-001');

INSERT INTO clientes (usuario, senha, email, nome_completo, telefone, cpf, endereco_id)
VALUES 
('', '', '', '', '', '', 1),
('user1', 'senha123', 'user1@email.com', 'Fulano Silva', '(11) 9876-5432', '111.222.333-00', 1),
('clienteA', 'abcd9876', 'clienteA@email.com', 'Cliente A', '(21) 1234-5678', '444.555.666-00', 2),
('joana88', 'senhaJoana', 'joana88@email.com', 'Joana Oliveira', '(31) 8765-4321', '777.888.999-00', 3),
('user123', 'abcxyz456', 'user123@email.com', 'Ciclano Pereira', '(41) 5678-1234', '222.333.444-00', 4),
('clienteXPTO', 'xpto1234', 'clientexpto@email.com', 'Cliente XPTO', '(51) 4321-8765', '555.666.777-00', 5),
('maria77', 'senhaMaria', 'maria77@email.com', 'Maria Costa', '(62) 9876-5432', '888.999.000-00', 6),
('fulana123', 'fulana456', 'fulana123@email.com', 'Fulana Lima', '(85) 5432-9876', '999.000.111-00', 7),
('user789', 'senha789', 'user789@email.com', 'Beltrano Gomes', '(11) 1234-5678', '666.777.888-00', 8),
('clienteZ', 'zxcv1234', 'clienteZ@email.com', 'Cliente Z', '(21) 8765-4321', '333.444.555-00', 9),
('ana99', 'senhaAna', 'ana99@email.com', 'Ana Santos', '(31) 2345-6789', '888.777.666-00', 10);

INSERT INTO funcionarios (nome_completo, cpf, telefone, nascimento_data, efetivacao_data, saida_data)
VALUES 
('João da Silva', '123.456.789-00', '(11) 9876-5432', '1990-05-15', '2021-02-28', NULL),
('Maria Oliveira', '987.654.321-00', '(21) 1234-5678', '1985-10-20', '2020-11-10', NULL),
('Pedro Santos', '555.123.777-00', '(31) 8765-4321', '1993-12-03', '2022-03-05', NULL),
('Ana Souza', '222.333.444-00', '(41) 5678-1234', '1988-08-25', '2023-01-18', NULL),
('Luiza Pereira', '777.888.999-00', '(51) 4321-8765', '1995-04-12', '2021-07-30', NULL),
('Marcos Costa', '444.555.666-00', '(62) 9876-5432', '1991-11-08', '2020-09-14', NULL),
('Carla Lima', '999.000.111-00', '(85) 5432-9876', '1987-02-28', '2022-06-25', NULL),
('Rafaela Gomes', '666.777.888-00', '(11) 1234-5678', '1994-07-17', '2023-04-20', NULL),
('Fernando Castro', '333.222.111-00', '(21) 8765-4321', '1989-09-30', '2021-12-05', NULL),
('Juliana Santos', '888.999.000-00', '(31) 2345-6789', '1996-03-22', '2020-10-10', NULL);

INSERT INTO produtos (nome, quantidade, preco, categoria, descricao)
VALUES 
('Notebook Dell Inspiron', 50, 2999.99, 'Informática', 'Notebook com processador Intel Core i5, 8GB RAM, 256GB SSD'),
('Smartphone Samsung Galaxy S21', 100, 2499.99, 'Eletrônicos', 'Smartphone com tela de 6.2 polegadas, câmera tripla, 128GB de armazenamento'),
('Monitor LG 27" 4K', 30, 799.99, 'Informática', 'Monitor IPS 4K Ultra HD com HDR10'),
('Câmera Sony Alpha A7 III', 20, 1999.99, 'Fotografia', 'Câmera Mirrorless Full Frame com sensor CMOS de 24.2MP'),
('Fone de Ouvido Bluetooth JBL', 80, 149.99, 'Áudio', 'Fone de ouvido sem fio com cancelamento de ruído'),
('Teclado Mecânico RGB', 60, 129.99, 'Informática', 'Teclado mecânico com retroiluminação RGB personalizável'),
('Roteador Wi-Fi TP-Link', 40, 79.99, 'Redes', 'Roteador dual band de alta velocidade'),
('Impressora Multifuncional HP', 25, 199.99, 'Informática', 'Impressora jato de tinta colorida com scanner e copiadora'),
('Mouse Gamer Logitech', 70, 69.99, 'Informática', 'Mouse óptico para jogos com sensor de alta precisão'),
('Caixa de Som Bluetooth JBL', 90, 119.99, 'Áudio', 'Caixa de som portátil à prova d''água');

INSERT INTO servicos (nome, preco, descricao, categoria, situacao)
VALUES 
('Limpeza', 120.00, 'Este serviço envolve a limpeza física e virtual do sistema, removendo arquivos desnecessários, otimizando o desempenho e a organização do dispositivo.', 'Tecnologia', 'Ativo'),
('Formatação', 100.00, 'A formatação consiste na exclusão completa de dados do dispositivo e na reinstalação do sistema operacional, resultando em um sistema limpo e restaurado.', 'Tecnologia', 'Ativo'),
('Montagem', 170.00, 'Esse serviço abrange a montagem física de componentes de hardware, como computadores ou dispositivos tecnológicos, garantindo sua correta configuração e funcionamento.', 'Tecnologia', 'Ativo'),
('Instalações e configurações', 89.90, 'Inclui a instalação de softwares e configurações personalizadas de acordo com as necessidades do cliente, garantindo que tudo funcione conforme desejado.', 'Tecnologia', 'Ativo'),
('Suporte técnico', 429.90, 'Este serviço oferece suporte especializado para resolver problemas técnicos, oferecendo assistência remota ou presencial para garantir o correto funcionamento dos dispositivos.', 'Tecnologia', 'Ativo'),
('Substituições de softwares e hardwares', 178.90, 'Envolve a substituição de softwares ou hardwares danificados ou desatualizados por versões mais recentes ou funcionais, melhorando o desempenho do dispositivo.', 'Tecnologia', 'Ativo'),
('Atualizações', 50.00, 'Esse serviço oferece a atualização de softwares e sistemas para as versões mais recentes, garantindo segurança, correções de bugs e novos recursos.', 'Tecnologia', 'Ativo'),
('Teste de Desempenho', 60.00, 'Realiza testes e análises para avaliar o desempenho do dispositivo, identificando possíveis problemas e otimizações para melhorar sua eficiência.', 'Tecnologia', 'Ativo');


INSERT INTO carrinho (produto_id, servico_id, cliente_id) VALUES 
(1, null, 2),
(null, 1, 2),
(null, 4, 2),
(6, null, 2),
(4, null, 2)

BEGIN TRANSACTION;

-- Inserir resumo da compra na tabela ResumoCompra
INSERT INTO ResumoCompra (IdUsuario, NomeProdutoServico, Quantidade, PrecoTotal)
SELECT CU.IdUsuario, 
       COALESCE(P.Nome, S.Nome) AS NomeProdutoServico,
       CU.Quantidade,
       CU.Quantidade * COALESCE(P.PrecoUnitario, S.PrecoUnitario) AS PrecoTotal
FROM CarrinhoUsuario CU
LEFT JOIN Produtos P ON CU.IdProduto = P.Id
LEFT JOIN Servicos S ON CU.IdServico = S.Id
WHERE CU.IdUsuario = 1;

-- Deletar itens do carrinho para o IdUsuario = 1
DELETE FROM CarrinhoUsuario WHERE IdUsuario = 1;

COMMIT TRANSACTION;


select * from clientes;
select * from funcionarios
select * from enderecos
select * from produtos
select * from servicos
select * from carrinho

UPDATE carrinho SET quantidade = quantidade + -1 WHERE id = 2