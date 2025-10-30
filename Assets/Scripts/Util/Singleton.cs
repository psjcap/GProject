using System;
using System.Collections.Generic;
using System.Reflection;

public class Singleton
{
    private static List<Type> _singletons = new();

    protected static void OnInstanced<T>() where T : class, new()
    {
        _singletons.Add(typeof(T));
    }

    public static void RemoveAllSingletons()
    {
        foreach (var singletonType in _singletons)
            singletonType.GetField("_instance", BindingFlags.Static | BindingFlags.NonPublic)?.SetValue(null, null);
        _singletons.Clear();
    }
}

public class Singleton<T> : Singleton where T : class, new()
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
                OnInstanced<Singleton<T>>();
            }
            return _instance;
        }
    }
}