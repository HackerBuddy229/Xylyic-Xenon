using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xylyic_Xenon.Models;
using Xylyic_Xenon.Services;

namespace Xylyic_Xenon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(WordService wordService)
        {

            var random = new Random();

            var stringBuilder = new StringBuilder(WordFormattingService.ChangeFirstLetterToCap(
                wordService._Adjectives[random.Next(
            maxValue: wordService._Adjectives.Count(),
            minValue: 0
            )]
            ));

            
            stringBuilder.Append(" ");
            stringBuilder.Append(WordFormattingService.ChangeFirstLetterToCap(
                wordService._Nounes[
                    random.Next(
                        maxValue:wordService._Nounes.Count(),
                        minValue: 0
                        
                        )
                ]
            )
                

            );
            return View(new IndexViewModel(stringBuilder.ToString()));
        }

        public IActionResult Ai(WordService wordService){

            var random = new Random();

            var stringBuilder = new StringBuilder(WordFormattingService.ChangeFirstLetterToCap(
                wordService._Adjectives[random.Next(
            maxValue: wordService._Adjectives.Count(),
            minValue: 0
            )]
            ));

            
            stringBuilder.Append(" ");
            stringBuilder.Append(WordFormattingService.ChangeFirstLetterToCap(
                wordService._Nounes[
                    random.Next(
                        maxValue:wordService._Nounes.Count(),
                        minValue: 0
                        
                        )
                ]
            )
                

            );

            return View(new IndexViewModel(stringBuilder.ToString()));
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
