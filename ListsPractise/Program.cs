namespace ListsPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<int> fibNumbers= [1,1];


            ////next element is found by taking the sum of the previous two numbers

            //var previous1 = fibNumbers[fibNumbers.Count - 1];
            //var previous2 = fibNumbers[fibNumbers.Count - 2];

            //fibNumbers.Add(previous1+previous2);   

            //foreach(int fibNumber in fibNumbers) 
            //{
            //    Console.WriteLine(fibNumber);
            //}
           var nums = CalcFib();

           foreach (var x in nums) { Console.WriteLine(x); }


        }


       public static List<int> CalcFib() 
       {
            List<int> nums = [1, 1];

            var count = 18;
            while(count!=0) 
            {
                var prev1 = nums[nums.Count-1];
                var prev2 = nums[nums.Count-2];  
                var sum = prev1 + prev2;

                nums.Add(sum);

                count--;
            }
            
            return nums;

       }
    }
}
