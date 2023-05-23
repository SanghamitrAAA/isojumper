using UnityEngine;

public class LoadPersistentObjects
{
   [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
   public static void Execute()
   {
        var resource = Resources.Load("--- Managers ---");
        if (resource != null)
        {
                Object.DontDestroyOnLoad(Object.Instantiate(resource));
        }
   }
}
