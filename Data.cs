using SQLite;

namespace TUGAS5_D_672018025
{
    [Table("Data")]
    public class Data
    {
        private int id;
        private string name;
        private string phone;
        private string email;
        private string gender;
        private string note;
        private int image;
        //[PrimaryKey, AutoIncrement, Column("_id")]

        public int Id { get => id; set => id = value; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Note { get; set; }
        public int Image { get; set; }
    }
}