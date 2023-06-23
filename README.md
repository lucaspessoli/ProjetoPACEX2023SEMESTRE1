<h1 align="center">PROJETO DE EXTENSAO</h1>

---

<h2>Participantes:</h2>
<h4>LUCAS PESSOLI - RA: 00229058</h4>
<h4>RENAN AUGUSTO MENDES CARLOS - RA: 00234708</h4>
<h4>VICTOR FAGUNDES RAMOS - RA: 00239823</h4>
<h4>NICOLAS LEANDRO - RA: 00238714</h4>
<h4>ERICK DANIEL TEIXEIRA VIER - RA: 00235908</h4>

---

<h1 align="center">SHOWCASE</h1>

https://github.com/lucaspessoli/ProjetoPACEX2023SEMESTRE1/assets/115120374/d6dcb071-56f1-40f8-aea9-b7858eeec3f0

<h1 align="center">CONFIGURAÇÕES</h1>

Ajuste para as configurações do seu banco de dados para rodar:
```C#
String conexaoString = "server=localhost;database=;uid=;pwd=;";
```



<h1 align="center">BANCO DE DADOS</h1>


```sql
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

SELECT * from Pessoa

SELECT * from Avaliacao

SELECT * from Itens_avaliado

```

<h1 align="center">CRONOGRAMA ESTILO KANBAM</h1>

![image](https://github.com/lucaspessoli/ProjetoPACEX2023SEMESTRE1/assets/115120374/8a6fd979-10f9-40dd-8ca5-6e214ae9fa45)

<h1 align="center">DIAGRAMADE DE RELACIONAMENTO ENTIDADE</h1>

![image](https://github.com/lucaspessoli/ProjetoPACEX2023SEMESTRE1/assets/115120374/b9e2150b-f40e-49b3-9f91-00c02e039c88)


