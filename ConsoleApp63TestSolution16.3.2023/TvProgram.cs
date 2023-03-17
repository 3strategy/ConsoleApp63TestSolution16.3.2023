namespace ConsoleApp63TestSolution16._3._2023
{
  /// <summary>
  /// שאלה 3 סעיף א
  /// </summary>
  public class TvProgram
  {
    #region שדות/תכונות: אין צורך להגדיר אותם
    private int code;
    private int day;
    private bool isSport;
    #endregion
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
    #region GetIsSport  אין צורך לכתוב את 
    internal bool GetIsSport()
    {
      throw new NotImplementedException();
    }
    #endregion
  }
}
