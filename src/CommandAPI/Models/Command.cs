using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommandAPI.Models
{
    public class Command
    {
        [Key]
        public int Id {get; set;}
        public string HowTo {get; set;}
        public string platform {get; set;}
        public string CommandLine {get; set;}
    }
}