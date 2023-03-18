namespace ConsoleApp63TestSolution16._3._2023
{
  public class AllNumbers
  {
    #region תשתית בלבד. אין צורך לרשום בבחינה
    int[] arrayNum;
    public AllNumbers()
    {
      arrayNum = new int[] { 7, 5, 8, 9, 3, 4 }; //סתם לבדיקה
    }
    public AllNumbers(int[] arrNum)
    {
      arrayNum = new int[arrNum.Length];
      for (int i = 0; i < arrNum.Length; i++)
      {
        arrayNum[i] = arrNum[i];
      }
    }
    #endregion

    /// <summary>
    ///  foreach מימוש
    /// </summary>
    /// <returns></returns>
    public int LastOddValue4()
    {
      int value = 0;
      foreach (var item in arrayNum)
        if (item % 2 != 0)
          value = item;
      return value;
    }
      /// <summary>
      /// forr מימוש בלולאה לאחור 
      /// </summary>
      /// <returns></returns>
      public int LastOddValue()
    {
      for (int i = arrayNum.Length - 1; i >= 0; i--)
        if (arrayNum[i] % 2 == 1)
          return arrayNum[i];
      return 0; // "בלי זה תהיה שגיאת "לא כל הנתיבים מחזירים ערך
    }

    /// <summary>
    /// מימוש בלולאה קדימה עם גישה אחורה
    /// </summary>
    /// <returns></returns>
    public int LastOddValue2()
    {
      for (int i = 1; i <= arrayNum.Length; i++)
        if (arrayNum[^i] % 2 == 1)
          return arrayNum[^i]; //מהסוף i- התא ה
      return 0; //לא אמור לקרות אף פעם אבל חייבים להחזיר משהו
    }
    /// <summary>
    /// מימוש בלולאה קדימה
    /// </summary>
    /// <returns></returns>
    public int LastOddValue3()
    {
      int res = 0;
      for (int i = 0; i < arrayNum.Length; i++)
        if (arrayNum[i] % 2 == 1)
          res = i;
      return arrayNum[res];
    }
    


  }
}
