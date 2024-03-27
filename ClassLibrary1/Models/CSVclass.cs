using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class CSVclass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthplace { get; set; }
        public string Occupation { get; set; }
        public DateTime Birthdate { get; set; }

        public CSVclass()
        {
        }

        public CSVclass(string line)
        {
            string[] line_split = line.Split(';');
            Id = int.Parse(line_split[0]);
            Name = line_split[1];
            Age = Convert.ToInt32(line_split[2]);
            Birthplace = line_split[3];
            Occupation = line_split[4];
            Birthdate = Convert.ToDateTime(line_split[5]);
        }

        public override string? ToString()
        {
            return $"{Name}, {Age} years old, works as a(n) {Occupation}, born on {Birthdate} in {Birthplace}";
        }
    }
}
