using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_Note_Store
{
    
    public class Note
    {
        public string State { get; set; }
        public string Name { get; set; }
    }
    public class NotesStore
    {
        private List<Note> Notes;
        public NotesStore()
        {
            Notes = new List<Note>();
        }
        public void AddNote(String state, String name)
        {
            //validation check
            if (name == "")
            {
                throw new Exception("Name cannot be empty");
            }

            if (state == "completed" || state == "active" || state == "others")
            {
                Notes.Add(new Note
                {
                    Name = name,
                    State = state
                });
            }
            else
            {
                throw new Exception($"Invalid state {state}");
            }


        }
        public List<String> GetNotes(String state)
        {
            List<string> returnList = new List<string>();
            if (state == "completed" || state == "active" || state == "others")
            {
                foreach (var note in Notes)
                {
                    if (note.State == state)
                    {
                        returnList.Add(note.Name);
                    }
                }
                return returnList;
            }
            else
            {
                throw new Exception($"Invalid state {state}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
