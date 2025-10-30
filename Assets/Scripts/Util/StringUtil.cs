using System.Text;

public static class StringUtil
{
    private static StringBuilder _stringBuilder = new(256);

    public static string Format(string fmt, object arg0)
    {
        _stringBuilder.Clear();
        _stringBuilder.AppendFormat(fmt, arg0);
        return _stringBuilder.ToString();
    }
    
    public static string Format(string fmt, object arg0, object arg1)
    {
        _stringBuilder.Clear();
        _stringBuilder.AppendFormat(fmt, arg0, arg1);
        return _stringBuilder.ToString();
    }

    public static string Format(string fmt, object arg0, object arg1, object arg2)
    {
        _stringBuilder.Clear();
        _stringBuilder.AppendFormat(fmt, arg0, arg1, arg2);
        return _stringBuilder.ToString();
    }

    public static string Format(string fmt, params object[] args)
    {
        _stringBuilder.Clear();
        _stringBuilder.AppendFormat(fmt, args);
        return _stringBuilder.ToString();
    }
}
