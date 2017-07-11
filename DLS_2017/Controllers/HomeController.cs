using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DLS_2017.Models;

namespace DLS_2017.Controllers
{
    public class HomeController : Controller
    {
        public ISpeakerRepository _ISpeakerRepository { get; private set; }
        public IParticipantRepository _IParticipantRepository { get; private set; }


        public HomeController(ISpeakerRepository sprep, IParticipantRepository parrep)
        {
            _ISpeakerRepository = sprep;
            _IParticipantRepository = parrep;
        }

        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Speaker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Speaker(Speaker sp)
        {
            if (ModelState.IsValid)
            {
                _ISpeakerRepository.AddSpeaker(sp);
                return RedirectToAction("RegisterCompletedSpeaker");
            }

            return View(sp);
        }

        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Participant part)
        {
            if(ModelState.IsValid)
            {
                _IParticipantRepository.AddParticipant(part);
                return RedirectToAction("RegisterCompleted");
            }
            
            return View(part);
            
        }
        public IActionResult RegisterCompleted()
        {
            return View();
        }

        public IActionResult RegisterCompletedSpeaker()
        {
            return View();
        }


    }
}
