using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DLS_2017.Models
{
    public interface ISpeakerRepository
    {
        void AddSpeaker(Speaker sp);

        IEnumerable<Speaker> GetSelectedSpeakers();
    }
}
