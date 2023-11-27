CREATE TRIGGER calcular_preco_total
ON carrinho
AFTER INSERT, UPDATE
AS
BEGIN
    -- Atualizar preco_total para novos registros inseridos
    UPDATE carrinho
    SET preco_total = (p.preco * i.quantidade)
    FROM carrinho c
    JOIN inserted i ON c.id = i.id
    LEFT JOIN produtos p ON i.produto_id = p.id
    WHERE i.produto_id IS NOT NULL;

    -- Atualizar preco_total para registros atualizados
    UPDATE carrinho
    SET preco_total = (s.preco * i.quantidade)
    FROM carrinho c
    JOIN inserted i ON c.id = i.id
    LEFT JOIN servicos s ON i.servico_id = s.id
    WHERE i.servico_id IS NOT NULL;
END;