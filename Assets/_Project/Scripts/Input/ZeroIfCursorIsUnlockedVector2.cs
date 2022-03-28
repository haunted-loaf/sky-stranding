namespace NNI.Core.Input {
  using UnityEditor;
  using UnityEngine;
  using UnityEngine.InputSystem;

#if UNITY_EDITOR
  [InitializeOnLoad]
#endif
  public class ZeroIfCursorIsUnlockedVector2 : InputProcessor<Vector2> {

#if UNITY_EDITOR
    static ZeroIfCursorIsUnlockedVector2()
    {
      Initialize();
    }
#endif

    [RuntimeInitializeOnLoadMethod]
    static void Initialize () {
      InputSystem.RegisterProcessor<ZeroIfCursorIsUnlockedVector2>();
    }

    public override Vector2 Process (Vector2 value, InputControl control) {
      return value * (Cursor.lockState == CursorLockMode.None ? 0 : 1);
    }

  }

}
