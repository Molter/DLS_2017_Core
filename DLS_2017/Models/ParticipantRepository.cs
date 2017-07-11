using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DLS_2017.Models
{
    public class ParticipantRepository : IParticipantRepository
    {
        public AppDbContext _appDbContext { get; private set; }

        public ParticipantRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Participant> Participants { get {
                return _appDbContext.Participants;
        } }

        public void AddParticipant(Participant part)
        {
            _appDbContext.Participants.Add(part);
            _appDbContext.SaveChanges();

        }

        public Participant RaffleItem()
        {
            Random random = new Random();
            var list = this.Participants.ToList();
            int start2 = random.Next(0, list.Count);
            return list.ToArray()[start2];
        }
    }
}
