using System;

namespace dreamteam
{
    class Evan : IPerson
    {
        private string __specialProperty { get; set; }
        private string __firstName { get; set; }
        private string __lastName { get; set; }

        public string FullName => $"{__firstName} {__lastName}";

        public void Work()
        {
            Console.WriteLine("Long technical talks and politics");
        }
        public Evan(string specialProperty, string firstName, string lastName)
        {
            __specialProperty = specialProperty;
            __firstName = firstName;
            __lastName = lastName;
        }
    }
}
