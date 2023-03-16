using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63TestSolution16._3._2023
{
  /// <summary>
  /// סעיף ב' כותרת המחלקה
  /// </summary>
  public class TvWeek
  {
    // (מאד לא מקובל להגדיר את המערך כתכונה (ראו בסוף הקוד
    // החצנתו כתכונה היא לכל הפחות מוזרה.
    // 'שתי השורות להלן הן ה"תשובה" לסעיף ב  
    private TvProgram[] arrProg;
    // !!! Setter שאסור לכתוב עבורו  current אותו הדבר לגבי השדה 
    // בבחינות הבגרות משתמשים במונח תכונה גם עבור השדה, וצריך להתרגל לטעות הזו
    // שתחזור על עצמה באופן סיסטמטי
    private int current;

    /// <summary>
    /// 'סעיף ג
    /// מוסיף תוכנית למערך במקום הפנוי הבא
    /// </summary>
    /// <param name="prog">התכנית אותה יש להוסיף</param>
    public void AddProgram(TvProgram prog)
    {
      arrProg[current++] = prog;
    }
    /// <summary>
    /// 'סעיף ד
    /// </summary>
    /// <returns>returns the number of programs currently in arrProg</returns>
    public int GetNumSportProgs()
    {
      int res = 0;
      foreach (TvProgram p in arrProg)
        if (p.GetIsSport())
          res += 1;
      return res;
    }


    #region ==הקוד שלהלן אינו מקובל, אך גם לא נדרש בשאלה ==התכונות
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
