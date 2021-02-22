using System;

namespace note_api.Data
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Category Category { get; set; }
        public bool Completable { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }
}