using System.ComponentModel.DataAnnotations.Schema;

namespace M2S10API.Models
{
    [Table("Matrícula")]
    public class Register
    {
        public int Id { get; set; }

        [ForeignKey("Class"), Column("Id Turma")]
        public int IdClass { get; set; }

        [ForeignKey("Student"), Column("Id Aluno")]
        public int IdStudant { get; set; }

        [Column("Data Matricula")]
        public DateTime? RegisterDate { get; set; }

        private Class Class { get; set; }
        private Student Student { get; set; }
    }
}
