using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DLS_2017.Models
{
    public class SpeakerRepository : ISpeakerRepository
    {
        public AppDbContext _appDbContext { get; private set; }

        public SpeakerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddSpeaker(Speaker sp)
        {
            _appDbContext.Speakers.Add(sp);
            _appDbContext.SaveChanges();

        }

        public IEnumerable<Speaker> GetSelectedSpeakers()
        {
            return _appDbContext.Speakers.Where(x => x.IsSelected == true);
        }
    }
}
