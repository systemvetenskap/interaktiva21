using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class Club
    {
        // lista med medlemmar
        List<IWriteClub> members = new List<IWriteClub>();
        public Club()
        {

        }

        public void AddNewMember(IWriteClub member)
        {
            // lägg till listan
            members.Add(member);
        }

    }
}
