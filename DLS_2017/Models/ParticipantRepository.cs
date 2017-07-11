using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DLS_2017.Models
{
    public class ParticipantRepository : IParticipantRepository
    {

        public IEnumerable<Participant> Participants => throw new NotImplementedException();

        public void AddParticipant(Participant part)
        {
            throw new NotImplementedException();
        }

        public Participant RaffleItem()
        {
            throw new NotImplementedException();
        }
    }
}
