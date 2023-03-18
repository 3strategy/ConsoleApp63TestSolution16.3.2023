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
      //MainQ5(); // קריאה לשאלה 5. בבחינה לא צריך
      Random rnd = new Random();
      int[] arr = new int[300];
      for (int j = 0; j < 3; j++)
      {
        for (int i = 0; i < arr.Length; i++)
          arr[i] = rnd.Next(1, 6);
        int a = MainQ52(arr); // בדיקה משווה בין פתרונות
        int b = MainQ53(arr);
        Debug.Assert(a == b);
      }

      //MainQ1();
    }
    public static void MainQ1()
    {
      AllNumbers all = new AllNumbers();
      Console.WriteLine(all.LastOddValue() + " " + all.LastOddValue2() + " " + all.LastOddValue3());
      Debug.Assert(all.LastOddValue() == all.LastOddValue2());
      Debug.Assert(all.LastOddValue() == all.LastOddValue3());
    }
    #endregion

    /// <summary>
    /// פתרון רשמי שאלה 5
    /// </summary>
    public static void MainQ5()
    {
      // שאלה 5 מערך מונים
      int[] ratings = new int[6];// הערכים האפשריים ועוד 1 כדי שיהיה פשוט יותר
      int maxInd = 0;
      for (int i = 0; i < 40; i++)
      {
        Console.WriteLine("enter your rating 1-5");
        int n = int.Parse(Console.ReadLine()); // בבחינה לרשום קלוט מספר שלם 
        ratings[n]++;
      }
      for (int i = 0; i < ratings.Length; i++)
        if (ratings[i] > ratings[maxInd]) // ניתן היה גם לשים את התנאי בתוך הלולאה הקודמת
          maxInd = i;
      Console.WriteLine("the most frequent rating was: " + maxInd);
    }

    /// <summary>
    /// (פתרון מקוצר לשאלה 5. מוצג לשם נוחות עם מערך (במקום קלט 
    /// ומחזיר ערך במקום להדפיס
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int MainQ52(int[] arr)
    {
      int[] ratings = new int[6];// הערכים האפשריים ועוד 1 כדי שיהיה פשוט יותר
      int maxInd = 0;

      for (int i = 0; i < arr.Length; i++)
        if (++ratings[arr[i]] > ratings[maxInd])
          maxInd = arr[i];
      return maxInd;
    }

    public static int MainQ53(int[] arr)
    {
      // דוגמא לפתרון ללא מונים. עובד אבל איטי בהרבה
      int maxRate = 0, rateAmount = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        int count = 0;
        foreach (var item in arr)
        {
          if (arr[i] == item)
          {
            count++;
            if (count > rateAmount)
            {
              rateAmount = count;
              maxRate = item;
            }
          }
        }
      }
      //Console.WriteLine($"the most rated are {maxRate} rated#  {rateAmount}");
      return maxRate;
    }
  }
}