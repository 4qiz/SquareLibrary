SELECT p.Title, c.Title
FROM Product p
LEFT JOIN ProductHasCategory pc ON p.ProductId = pc.ProductId
LEFT JOIN Category c ON pc.CategoryId = c.CategoryId;