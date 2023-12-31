using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListWPFApp.Models
{
    public class Task
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Category Category { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
    }
}
