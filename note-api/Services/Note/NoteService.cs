using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using note_api.Data;
using note_api.DTOs;

// using note_api.Data;

namespace note_api.Services.Note
{
    public class NoteService : INoteService
    {
        private readonly NoteDataContext _dataContext;

        public NoteService(NoteDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        
        public async Task<IEnumerable<Data.Note>> GetNotes()
        {
            try
            {
                return await _dataContext.Notes.ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        public async Task<Data.Note> GetNote(int id)
        {
            try
            {
                return await _dataContext.Notes.FirstOrDefaultAsync(note => note.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public async Task<Data.Note> CreateNote(CreatedNote newNote)
        {
            try
            {
                var note = new Data.Note()
                {
                    Title = newNote.Title,
                    Text = newNote.Text,
                    IsCompleted = newNote.IsCompleted,
                    Completable = newNote.Completable,
                    CreatedDate = DateTime.Now,
                    LastUpdateTime = DateTime.Now
                };
                
               await _dataContext.Notes.AddAsync(note);
               await _dataContext.SaveChangesAsync();
               return note;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task<Data.Note> UpdateNote(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}