using System;

namespace dreamteam
{
    class Me : IPerson
    {
        private string __specialProperty { get; set; }
        private string __firstName { get; set; }
        private string __lastName { get; set; }

        public string FullName => $"{__firstName} {__lastName}";

        public void Work()
        {
            Console.WriteLine("Allow me to continuously shoot myself in the foot with my shitty code.");
        }
        public Me(string specialProperty, string firstName, string lastName)
        {
            __specialProperty = specialProperty;
            __firstName = firstName;
            __lastName = lastName;
        }
    }
}
