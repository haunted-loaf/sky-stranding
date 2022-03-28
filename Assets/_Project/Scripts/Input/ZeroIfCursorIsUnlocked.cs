namespace NNI.Core.Input {
  using UnityEditor;
  using UnityEngine;
  using UnityEngine.InputSystem;

#if UNITY_EDITOR
  [InitializeOnLoad]
#endif
  public class ZeroIfCursorIsUnlocked : InputProcessor<float> {

#if UNITY_EDITOR 
    static ZeroIfCursorIsUnlocked()
    {
      Initialize();
    }
#endif

    [RuntimeInitializeOnLoadMethod]
    static void Initialize () {
      InputSystem.RegisterProcessor<ZeroIfCursorIsUnlocked>();
    }

    public override float Process (float value, InputControl control) {
      return value * (Cursor.lockState == CursorLockMode.None ? 0 : 1);
    }

  }

}
