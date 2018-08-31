using System;

namespace dreamteam
{
    class Jenn : IPerson
    {
        private string __specialProperty { get; set; }
        private string __firstName { get; set; }
        private string __lastName { get; set; }

        public string FullName => $"{__firstName} {__lastName}";

        public void Work()
        {
            Console.WriteLine("Did you know I have an Iphone 5?");
        }
        public Jenn(string specialProperty, string firstName, string lastName)
        {
            __specialProperty = specialProperty;
            __firstName = firstName;
            __lastName = lastName;
        }
    }
}
