namespace ConsoleApp5
{
    internal class Program
    {
        public static bool IsPalindrome(string str)
        {
            //Question 20
            //Random rnd=new Random();
            //int i=rnd.Next(str.Length);
            //int j=rnd.Next(str.Length);
            //int temp=i;
            //if(i>j)
            //{
            //i=j;
            //j=temp;
            //}
            //return IsPalindrome(str, i, j);
            return IsPalindrome(str, 0, str.Length - 1);
        }

        public static bool IsPalindrome(string str,int i,int j)
        {
            if (i >= j)
                return true;
            if (str[i] != str[j])
                return false;
            return IsPalindrome(str,i+1,j-1);
        }

        public static bool IsPalindrome(string str, int i)
        {
            if (i>= str.Length/2)
                return true;
            if (str[i] != str[str.Length-i-1])
                return false;
            return IsPalindrome(str, i + 1);
        }
        static void Main(string[] args)
        {
            string kuku = "never even";
            IsPalindrome(kuku);
        }
    }
}