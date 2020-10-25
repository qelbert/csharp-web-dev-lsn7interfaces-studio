using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        // field/properties: name, storageCapacity, contents, discType
        public readonly string name;
        public readonly double storageCapacity;
        private List<string> contents;
        public List<string> Contents
        {
            get { return contents; }
            internal set { contents = value; }
        }
        public readonly string discType;
        public const bool remoteAcces = true;

        public BaseDisc (string name) { }

        //public BaseDisc(string name, double storageCapacity, List<string> contents, string discType)
        //{
        //    Contents = contents;
        //}

kl        public void reportProperties()
        {
            Console.WriteLine(name + "\n" + storageCapacity + "\n" + contents + "\n" + discType);
        }

        public void eject()
        {
            Console.WriteLine("Eject pushes the disck out from the player.");
        }

        public void skipFile()
        {
            Console.WriteLine("Skip File forwards to the next item.");
        }
    }
}
