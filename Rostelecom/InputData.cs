using System.ComponentModel.DataAnnotations;

namespace RostelecomApplication
{
    public class InputData // модель входных данных для привязки
    {
        [Required]
        public int lenght_kod { get; set; }

        [Required]
        public int lenght_salt { get; set; }
    }
}
