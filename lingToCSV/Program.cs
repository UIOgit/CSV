using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace linqToCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection<ToCSV> objectCollection = new Collection<ToCSV>();
        }
    }

    public class ToCSV
    {
        public string Name;
        public Guid ObjectID;
        public string Name2;
        public bool IsRight;
        public double Width;
        public double Height;

        public ToCSV(string name, double w, double h)
        {
            Name = name;
            ObjectID = Guid.NewGuid();
            Name2 = string.Empty;
            IsRight = false;
            Width = w;
            Height = h;
        }
    }

}
