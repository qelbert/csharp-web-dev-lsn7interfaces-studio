﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SpinningDiscs
{
    public class CD : BaseDisc , IOpticalDisc
    {
        public List<string> tracks { get; set; }

        public CD(string name) : base(name) 
        {

        }

        //public CD(string name, double storageCapacity, List<string> contents, string discType, List<string> tracks) : base (name, storageCapacity, contents, discType)
        //{
        //    name = this.name;
        //    storageCapacity = this.storageCapacity;
        //    contents = this.Contents;
        //    discType = this.discType;
        //    tracks = this.tracks;
        //}

        public void createTrackList ()
        {
            foreach (string track in tracks)
            {
                Console.WriteLine(track);
            }
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }

        public void StoreData()
        {
            Console.WriteLine("A CD can store 700MB of data.");
        }

        public void ReadData()
        {
            Console.WriteLine("Most CDs can be played on a DVD player.");
        }

        //public void RewriteData()
        //{

        //}

        public void WriteData()
        {
            Console.WriteLine("A CD can have data written on at at the speed of 1.229 Mbit/s");
        }



        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
