using System.ComponentModel.DataAnnotations;
namespace TimerApp.Data
{
    public class History
    {
        [Key]
        public string? start_time { get; set; }

        public string? end_time { get; set; }
    }
}