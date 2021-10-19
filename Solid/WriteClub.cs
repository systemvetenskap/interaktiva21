using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    interface IWriteClub
    {
        void Write();
    }

    class Paper : IWriteClub
    {
        public void Scribble() { }

        public void Write()
        {
            // scribble
            throw new NotImplementedException();
        }
    }

    class Word : IWriteClub
    {
        public void Save() { }

        public void Write()
        {
            // Save
            throw new NotImplementedException();
        }
    }

    class Excel : IWriteClub
    {
        public void Write()
        {
            throw new NotImplementedException();
        }
    }


}
