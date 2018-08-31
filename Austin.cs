using System;

namespace dreamteam
{
    class Austin : IPerson
    {
        private string __specialProperty { get; set; }
        private string __firstName { get; set; }
        private string __lastName { get; set; }

        public string FullName => $"{__firstName} {__lastName}";

        public void Work()
        {
            Console.WriteLine("*insert jokes followed by copious amounts of Brett snorting here*");
        }
        public Austin(string specialProperty, string firstName, string lastName)
        {
            __specialProperty = specialProperty;
            __firstName = firstName;
            __lastName = lastName;
        }
    }
}
