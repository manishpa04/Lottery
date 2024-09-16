namespace LotteryNumbers
{
    public class LotteryNumber: ILotteryNumber
    {
        private int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public List<int> generateSixSetOfNumbers(string minrange, string maxrange)
        {
            int min = 0;
            int max = 0;

            Int32.TryParse(minrange, out min);
            Int32.TryParse(maxrange, out max);
            List<int> lotteryList = new List<int>();
            int i = 0;
            while (i < 6)
            {
                int number = randomNumber(min, max);
                if (!lotteryList.Contains(number))
                {
                    lotteryList.Add(number);
                    i++;
                }
            }
            return lotteryList;
        }
    }
}
