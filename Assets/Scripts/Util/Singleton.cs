using UnityEngine;

public class Singleton<T> : ISingleton where T : class
{
    public static T _instance;

    public static T Instance
    {
        get
        {
            return null;
        }
    }
    
    public virtual void OnInstanced()
    {
    }

    public virtual void OnDestroy()
    {
    }
}
