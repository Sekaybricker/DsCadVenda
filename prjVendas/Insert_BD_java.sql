-- Trocar "banco_java" pelo nome do seu banco (Ex.: fp050000000)
use banco_java;
set dateformat ymd;
INSERT INTO pc_clientes
           (codcli,nome,endereco,cidade,bairro,uf,cep,telefone,datanasc)
     VALUES
           (1, 'Zelao Silva', 'Rua do ze, 666','Sorocaba', 'Jd. Loucura','SP', '18066123', '1533445666', '1970/06/15');

INSERT INTO pc_clientes
           (codcli,nome,endereco,cidade,bairro,uf,cep,telefone,datanasc)
     VALUES
           (2, 'Tiao Bastiao', 'Av. Tiao, 123','Votorantim', 'Vila Bastiao','SP', '12333333', '1543336677', '1980/01/22');

INSERT INTO pc_Produto
			(codpro, descricao,quantidade, precounit)
	VALUES 
		(1, 'mouse',23, 12.3);

INSERT INTO pc_Produto
			(codpro, descricao,quantidade, precounit)
	VALUES 
		(2, 'teclado',11, 15.2);		

INSERT INTO pc_Produto
			(codpro, descricao,quantidade, precounit)
	VALUES 
		(3, 'pen drive',12, 25);	

INSERT INTO pc_Produto
			(codpro, descricao,quantidade, precounit)
	VALUES 
		(4, 'mouse pad',15, 10.22);
		
INSERT INTO pc_venda
		(numvenda,  datavenda, dataentrega, codcli, obs)
	VALUES
		(1, '1999-11-11', '1999-11-02', 1, 'lalalaala blablabla');

INSERT INTO pc_venda
		(numvenda,  datavenda, dataentrega, codcli, obs)
	VALUES
		(2,'2009-02-18', '2009-02-20', 2,'hahahha hahahaha');
		
INSERT INTO pc_itemvenda
		(numvenda, codpro, quantidade, precounit)
	VALUES
		(1,	2,	1,	15.2);

INSERT INTO pc_itemvenda
		(numvenda, codpro, quantidade, precounit)
	VALUES
		(1,	1,	4,	12.3);

INSERT INTO pc_itemvenda
		(numvenda, codpro, quantidade, precounit)
	VALUES	
		(1,	4,	4,	10.22);
	
INSERT INTO pc_itemvenda
		(numvenda, codpro, quantidade, precounit)
	VALUES
		(2,	4,	1,	10.22);
	
INSERT INTO pc_itemvenda
		(numvenda, codpro, quantidade, precounit)
	VALUES
		(2,	2,	2,	25);