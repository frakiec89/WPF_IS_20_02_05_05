using System.ComponentModel.DataAnnotations;


namespace WPF_IS_20_02_05_05.DB
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Telefone { get; set; }
        public string GroupName { get; set; }
    }
}
