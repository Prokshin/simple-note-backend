using System.Collections.Generic;
using System.Threading.Tasks;
using note_api.DTOs;

namespace note_api.Services.Note
{
    public interface INoteService
    {
        public Task<IEnumerable<Data.Note>> GetNotes();
        public Task<Data.Note> GetNote(int id);
        public Task<Data.Note> CreateNote(CreatedNote newNote);
        public Task<Data.Note> UpdateNote(int id);
    }
}