select Estudante.Id as 'Id do Estudante', Estudante.Nome, Estudante.Telefone, Estudante.[E-mail], Estudante.Cpf, Estudante.[Data de Nascimento], 
	   Turma.Id as 'Id da Turma ', Turma.[Data de in�cio], Turma.[Carga Hor�ria], Turma.[Data de t�rmino], 
	   Cursos.Id as 'Id do Curso', Cursos.Nome, Cursos.Requisito, Cursos.Valor,
	   Instructors.Id as 'Id do Instrutor', Instructors.Nome, Instructors.ValorHora, Instructors.Telefone, Instructors.[E-mail], Instructors.Certificado
from Matr�cula
inner join Estudante on Estudante.Id = [Id Aluno]
inner join Turma on Turma.Id = [Id Turma]
inner join Cursos on Cursos.Id = [Id Curso]
inner join Instructors on Instructors.Id = [Id Instrutor]
