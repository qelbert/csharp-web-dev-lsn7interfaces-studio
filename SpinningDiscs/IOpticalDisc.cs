using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc

    {
        const string shape = "circular"; 
        void SpinDisc();
        // CD's and DVD's spin at different rates
        void StoreData();
        // CD's and DVD's store similar data but have different capacities
        void ReadData();
        // DVDs can store films and must be played on a dvd player vs a cd player
        //void RewriteData();
        void WriteData();
    }
}
