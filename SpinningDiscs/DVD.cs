using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc , IOpticalDisc
    {

        public List<string> chapters { get; set; }

        public DVD (string name) : base(name) {
        }

        //public DVD (string name, double storageCapacity, List<string> contents, string discType, List<string> chapters) : base(name, storageCapacity, contents, discType)
        //{
        //    name = this.name;
        //    storageCapacity = this.storageCapacity;
        //    contents = this.Contents;
        //    discType = this.discType;
        //    chapters = this.chapters;
        //}

        public void createChapterList()
        {
            foreach (string chapter in chapters)
            {
                Console.WriteLine(chapter);
            }
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }

        public void StoreData()
        {

        }

        public void ReadData()
        {

        }

        public void RewriteData()
        {

        }
        // group files by category (film, extras, other) (interface)
        // store gui for menu ("play film") (interface)
        // store video's "extras" files (games, etc)
        // field/properties: name, storageCapacity, contents, discType

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
