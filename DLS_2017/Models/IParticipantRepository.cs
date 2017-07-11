using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DLS_2017.Models
{
    public interface IParticipantRepository
    {
        IEnumerable<Participant> Participants { get; }

        void AddParticipant(Participant part);

        Participant RaffleItem();
    }
}
