# Features that will be implemented
>- Registration, Update, Cancellation, and Consultation of Freelance Projects (individual or list)
>- Registration and Login of User and Freelancer and Client profiles
>- Add comments to a Freelancer service 
>- Define, Start and Finish Project


CLIENTE
=======
seq | Apelido | ativo
  1 | Parks   | yes
  2 | Baldo   | no
  3 | Bremil  | yes


CLIENTExCNPJs
=============
seq | idCLi | RzSocial | CNPJ                | Nome fantasia
  1 |     1 | Parks 1  | 99.999.999/0001-98  | Parks Matriz
  2 |     1 | Parks 2  | 99.999.999/0002-77  | Parks Filial
  3 |     2 | Baldo 1  | 00.000.000/0001-34  | Baldo Matriz
  4 |     3 | Bremil   | 11.111.111/0001-83  | Bremil IFF



PRODUTOS
========
seq | descricao | ativo
  1 | XTS       | yes
  2 | XWS       | no



t

CLIENTExCNPJxPRODUTO (Licencas)
====================
seq | idCliCNPJ | idProd | Validade   | Ativo
  1 |         1 |      1 | 31/05/2024 | no
  2 |         2 |      1 | 31/05/2024 | no
  3 |         3 |      1 | 31/05/2024 | no
  4 |         1 |      1 | 30/06/2024 | yes
  5 |         2 |      1 | 30/06/2024 | yes
  6 |         3 |      1 | 30/06/2024 | yes
