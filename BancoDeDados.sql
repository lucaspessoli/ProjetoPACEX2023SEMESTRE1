CREATE TABLE IF NOT EXISTS Itens_avaliado(
	id_item SERIAL PRIMARY KEY,
	descricao varchar(100)
);

CREATE TABLE IF NOT EXISTS Pessoa (
    ra INT PRIMARY KEY,
    nome varchar(120)
);


CREATE TABLE IF NOT EXISTS Avaliacao (
    id_avaliacao SERIAL PRIMARY KEY,
	item varchar(100),
    ra_pessoa INT,
    nota INT,
    comentario varchar(200),
    CONSTRAINT fk_idpessoa FOREIGN KEY (ra_pessoa) REFERENCES Pessoa (ra)
);

INSERT INTO Itens_avaliado (descricao) VALUES ('Professor');
INSERT INTO Itens_avaliado (descricao) VALUES ('Aluno');
INSERT INTO Itens_avaliado (descricao) VALUES ('Infraestrutura');
INSERT INTO Itens_avaliado (descricao) VALUES ('Funcionário');

DROP TABLE Avaliacao


SELECT * from Pessoa

SELECT * from Avaliacao

SELECT * from Itens_avaliado

