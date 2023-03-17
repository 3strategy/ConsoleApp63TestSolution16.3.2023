namespace ConsoleApp63TestSolution16._3._2023
{
  /// <summary>
  /// סעיף ב' כותרת המחלקה
  /// </summary>
  public class TvWeek
  {
    /// <summary>
    /// (מאד לא מקובל להגדיר את המערך כתכונה (ראו בסוף הקוד
    /// החצנתו כתכונה היא לכל הפחות מוזרה.
    /// 'שתי השורות להלן הן ה"תשובה" לסעיף ב  
    /// </summary>
    private TvProgram[] arrProg; // אין צורך לאתחל אותו באורך 100 אבל זה מותר
    /// <summary>
    /// !!! Setter שאסור לכתוב עבורו  current אותו הדבר לגבי השדה 
    /// בבחינות הבגרות משתמשים במונח תכונה גם עבור השדה, וצריך להתרגל לטעות הזו
    /// שתחזור על עצמה באופן סיסטמטי
    /// </summary>
    private int current;

    /// <summary>
    /// סעיף ג
    /// מוסיף תוכנית למערך במקום הפנוי הבא
    /// </summary>
    /// <param name="prog">התכנית אותה יש להוסיף</param>
    public void AddProgram(TvProgram prog)
    {
      arrProg[current++] = prog;
    }

    /// <summary>
    /// סעיף ד:
    /// 3 אלטרנטיבות
    /// </summary>
    /// <returns>returns the number of programs currently in arrProg</returns>
    public int GetNumSportProgs()
    {
      int res = 0;
      foreach (TvProgram p in arrProg)
        if (p is not null && p.GetIsSport())
          res += 1;
      return res;
    }

    public int GetNumSportProgs2() // alternative.
    {
      int res = 0;
      for (int i = 0; i < current; i++) // null-יבטיח שלא נגיע להפניות ל current
        if (arrProg[i].GetIsSport())
          res ++;
      return res;
    }


    #region ==הקוד שכאן אינו מקובל, אך גם לא נדרש בשאלה ==התכונות
    /// <summary>
    ///  getter of arrProg - מוזר
    /// </summary>
    /// <returns></returns>
    public TvProgram[] GetSetArrProg()
    {
      return arrProg;
    }
    /// <summary>
    /// Setter of arrProg - גרוע מאד!!!
    /// </summary>
    /// <param name="value"></param>
    public void SetSetArrProg(TvProgram[] value)
    {
      arrProg = value;
    }

    public int GetCurrent()
    {
      return current;
    }
    /// <summary>
    /// קל לראות למה השדה הזה לא אמור להיות תכונה
    /// כל שינוי שלו מבחוץ הוא דוגמא למצב של שיבוש
    /// בצורת הפעולה שת התכנית
    /// </summary>
    /// <param name="value">ממש רע לאפשר גישה כזו וזו בעצם דוגמא למה לא כל שדה הוא תכונה או צריך להפוך לתכונה</param>
    public void SetCurrent(int value)
    {
      current = value;
    }
    #endregion


  }
}
