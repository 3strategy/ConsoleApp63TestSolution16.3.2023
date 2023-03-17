using System.Diagnostics;

namespace ConsoleApp63TestSolution16._3._2023
{
  public class Program
  {
    // הפתרון מפוזר על פני כמה קבצי מחלקות
    // "להבדיל מבחינות קודמות לא כל דבר כאן "פועל
    // ואין קוד שבודק נכונות של כל דבר. זאת בהתחשב בעיקר בזמן פנוי
    // ובכך שהשאלות ברמה האלגוריתמית פשוטות 

    #region בדיקת שאלה 1: בבחינה אין צורך בקריאה לפעולות כשלא ביקשו
    public static void Main(string[] args)
    {
      MainQ5(); // קריאה לשאלה 5. בבחינה לא צריך
      MainQ1();
    }
    public static void MainQ1()
    { 
      AllNumbers all = new AllNumbers();
      Console.WriteLine(all.LastOddValue() + " " + all.LastOddValue2() + " " + all.LastOddValue3());
      Debug.Assert(all.LastOddValue() == all.LastOddValue2());
      Debug.Assert(all.LastOddValue() == all.LastOddValue3());
    }
    #endregion

    public static void MainQ5()
    { 
      // שאלה 5 מערך מונים
      int[] ratings = new int[6];// הערכים האפשריים ועוד 1 כדי שיהיה פשוט יותר
      int maxInd = 0;
      for (int i = 0; i < 40; i++)
      {
        Console.WriteLine("enter your rating 1-5");
        int n = int.Parse(Console.ReadLine()); // בבחינה לרשום קלוט מספר שלם 
        if (n > 5 || n < 1)
          continue;// לא נדרש אבל רצוי. קופץ לסיבוב הבא. לא למדנו ולא בחומר
        ratings[n]++;
      }
      for (int i = 0; i < ratings.Length; i++)
        if (ratings[i] > ratings[maxInd]) // ניתן היה גם לשים את התנאי בתוך הלולאה הקודמת
          maxInd = i;
      Console.WriteLine("the most frequent rating was: " + maxInd);
    }
  }
}