CREATE OR ALTER TRIGGER att ON carrinho 
AFTER INSERT
AS
BEGIN
    -- Atualização para produtos
    UPDATE produtos 
    SET quantidade = produtos.quantidade - inserted.quantidade
    FROM produtos 
    INNER JOIN inserted ON inserted.produto_id = produtos.id
    WHERE produtos.id = inserted.produto_id
    AND inserted.servico_id IS NULL; -- Verifica se é um produto, não um serviço

    UPDATE produtos 
    SET situacao = 'inativo' 
    WHERE quantidade < 1;

    -- Atualização para serviços
    UPDATE servicos 
    SET situacao = 'inativo' 
    FROM servicos 
    INNER JOIN inserted ON inserted.servico_id = servicos.id
    WHERE servicos.id = inserted.servico_id
    AND inserted.produto_id IS NULL; -- Verifica se é um serviço, não um produto
END;