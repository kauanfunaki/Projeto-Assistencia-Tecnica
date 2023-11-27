CREATE OR ALTER TRIGGER att ON carrinho 
AFTER INSERT
AS
BEGIN
    -- Atualiza��o para produtos
    UPDATE produtos 
    SET quantidade = produtos.quantidade - inserted.quantidade
    FROM produtos 
    INNER JOIN inserted ON inserted.produto_id = produtos.id
    WHERE produtos.id = inserted.produto_id
    AND inserted.servico_id IS NULL; -- Verifica se � um produto, n�o um servi�o

    UPDATE produtos 
    SET situacao = 'inativo' 
    WHERE quantidade < 1;

    -- Atualiza��o para servi�os
    UPDATE servicos 
    SET situacao = 'inativo' 
    FROM servicos 
    INNER JOIN inserted ON inserted.servico_id = servicos.id
    WHERE servicos.id = inserted.servico_id
    AND inserted.produto_id IS NULL; -- Verifica se � um servi�o, n�o um produto
END;