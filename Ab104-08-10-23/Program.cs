
using Ab104;

//Student[] students = new Student[] 
//{
//new Student("Ali", "Shukurlu", "Adnsu", 49),

//};

//foreach (var student in students)
//{
//  student.GetInfo();
//  student.CheckGraduationStatus();
//  student.GetDiplomDegree();

//   Console.WriteLine("-------------------------");

//}


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int reshadAge=0;
//        int aydanAge=0;
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine("Enter Reshad Point");
//            int reshadPoint = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Aydan Point");
//            int aydanPoint = int.Parse(Console.ReadLine());
//            int result = GetByCompetition(reshadPoint, aydanPoint, ref reshadPoint, ref aydanPoint);
//            Console.WriteLine(result);
//        }
//    }
//    public static int GetByCompetition(int n1,int n2,ref int n3,ref int n4)
//    {
//        if (n1 > n2)
//        {
//            n3++;
//            return n3;
//        }
//        else if (n1 < n2)
//        {
//            n4++;
//            return n4;
//        }
//        else
//        {
//            return 0;
//        }
//    }
//}


//internal class Program
//{
//    static void Main()
//    {
//        string phrase = Console.ReadLine();

//        string[] words = SplitByWord(phrase);

//        Console.WriteLine("Sozler:");
//        foreach (string item in words)
//        {
//            Console.WriteLine(item);
//        }
//    }

//    static string[] SplitByWord(string phrase)
//    {
//        string[] words = phrase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//        return words;
//    }
//}


//internal class Program
//{
//    static void Main()
//    {
//        string withoutTrim = Console.ReadLine();
//        string trim = TrimByWords(withoutTrim);

//        Console.WriteLine("Without Trim: " + withoutTrim);
//        Console.WriteLine("With Trim: " + trim);
//    }

//    static string TrimByWords(string phrase)
//    {
//        int start = 0;
//        while (start < phrase.Length && char.IsWhiteSpace(phrase[start]))
//        {
//            start++;
//        }
//        phrase = phrase.Substring(start);

//        int end = phrase.Length - 1;
//        while (end >= 0 && char.IsWhiteSpace(phrase[end]))
//        {
//            end--;
//        }
//        phrase = phrase.Substring(0, end + 1);

//        return phrase;
//    }
//}
