using System;
using SQLite;

namespace Notes.Models
{
    public class Note
    {
        //establecer en el modelo los campos de la base de datos.
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
