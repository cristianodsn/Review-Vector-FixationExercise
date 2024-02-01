using System;


namespace Rascunho.Entities
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString()
        {
            return $"Room: {Room}, Name: {Name}, Email: {Email}";
        }
    }
}
