using System;

namespace dreamteam
{
    class Brett : IPerson
    {
        private string __specialProperty { get; set; }
        private string __firstName { get; set; }
        private string __lastName { get; set; }

        public string FullName => $"{__firstName} {__lastName}";

        public void Work()
        {
            Console.WriteLine("I need to hard code all my things and stop working on styling so Emily won't be disappointed in me anymore.");
        }
        public Brett(string specialProperty, string firstName, string lastName)
        {
            __specialProperty = specialProperty;
            __firstName = firstName;
            __lastName = lastName;
        }
    }
}
