using System;
using UnityEngine;

namespace NNI.Core.Utils {

  public class Singleton<T> : MonoBehaviour where T : Component {

    private static T _instance;

    public static T instance {
      get {
        if (!_instance)
          _instance = GameObject.FindObjectOfType<T>();
        if (!_instance)
          _instance = new GameObject($"Singleton {typeof(T).Name}").AddComponent<T>();
        return _instance;
      }
    }

  }

}
