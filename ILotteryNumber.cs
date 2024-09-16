using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumbers
{
    public interface ILotteryNumber
    {
        public List<int> generateSixSetOfNumbers(string minrange, string maxrange);
    }
}
