using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> serverSide = new List<IPerson>();
            List<IPerson> clientSide = new List<IPerson>();

            Me me = new Me("C#", "Jordan", "Williams");
            Brett brett = new Brett("CSS", "Brett", "Shearin");
            JackBob jackbob = new JackBob("API", "Jacob", "Henderson");
            Jenn jenn = new Jenn("React", "Jenn", "Lawson");
            Austin austin = new Austin("Design", "Austin", "Gorman");
            Evan evan = new Evan("SQL", "Evan", "Lusky");

            serverSide.Add(me);
            serverSide.Add(evan);
            serverSide.Add(jackbob);

            clientSide.Add(jenn);
            clientSide.Add(austin);
            clientSide.Add(brett);

            foreach (var item in serverSide)
            {
                item.Work();
            }

            foreach (var item in clientSide)
            {
                item.Work();
            }
        }
    }
}
