namespace NNI.Core.Input {
  using UnityEditor;
  using UnityEngine;
  using UnityEngine.InputSystem;

#if UNITY_EDITOR
  [InitializeOnLoad]
#endif
  public class DifferentiateVector2 : InputProcessor<Vector2> {

#if UNITY_EDITOR
    static DifferentiateVector2()
    {
      Initialize();
    }
#endif

    [RuntimeInitializeOnLoadMethod]
    static void Initialize () {
      InputSystem.RegisterProcessor<DifferentiateVector2>();
    }

    public override Vector2 Process (Vector2 value, InputControl control) {
      return value / Time.deltaTime;
    }

  }

}
