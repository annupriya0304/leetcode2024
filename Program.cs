namespace leetcode;

class Program
{
    static int[] Main(int[] nums)
    {
        var result= new int[nums.Length*2];
       
         for (int i = 0; i < nums.Length; i++){

            result[i] = nums[i];
            result[nums.Length+i] = nums[i];
         }

        return result;
    }


    public static int[] permutation(int[] num){
    var result= new int[num.Length];
        
       for (int i = 0; i<  num.Length; i++){

         result[i]= num[num[i]];

       }

       return result;
    }
}
