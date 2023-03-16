using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63TestSolution16._3._2023
{
  /// <summary>
  /// שאלה 3 סעיף א
  /// </summary>
  public class TvProgram
  {
    //אין צורך להגדיר את השדות
    private int code;
    private int day;
    private bool isSport;
    public TvProgram() // מומלץ מאד לדאוג שתהיה גם פעולה בונה ללא פרמטים
    {
      //פעולה כזו יכול להכיל איתחולים או להיות ריקה
    }
    public TvProgram(int code, int day, bool isSport)
    {
      this.code = code;
      this.day = day;
      this.isSport = isSport;
    }
    #region אין צורך לכתוב
    internal bool GetIsSport()
    {
      throw new NotImplementedException();
    }
    #endregion
  }
}
