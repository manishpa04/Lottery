using LotteryNumbers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LotteryGnerator.Controllers
{
    [Route("api/Lottery")]
    [ApiController]
    public class LotteryController : ControllerBase
    {
        private ILotteryNumber lottteryNumber;
        public LotteryController(ILotteryNumber lottteryNumber)
        { 
        this.lottteryNumber = lottteryNumber;
        }
        
        [HttpGet(Name = "getLotteryNumbers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public string getLotteryNumbers( string min,string max)
        {
             
            var result = string.Join<int>(string.Empty, lottteryNumber.generateSixSetOfNumbers(min, max));
            return result;
        }
    }
}
