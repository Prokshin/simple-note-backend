using System.ComponentModel.DataAnnotations;
using note_api.Data;

namespace note_api.DTOs
{
    public class CreatedNote
    {
        [Required]
        public string Title { get; set; }
        public string Text { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public bool Completable { get; set; }
        public bool IsCompleted { get; set; }
    }
}