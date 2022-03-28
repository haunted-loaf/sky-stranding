namespace NNI.Core.Input {
  using UnityEditor;
  using UnityEngine;
  using UnityEngine.InputSystem;

#if UNITY_EDITOR
  [InitializeOnLoad]
#endif
  public class Differentiate : InputProcessor<float> {

#if UNITY_EDITOR
    static Differentiate()
    {
      Initialize();
    }
#endif

    [RuntimeInitializeOnLoadMethod]
    static void Initialize () {
      InputSystem.RegisterProcessor<Differentiate>();
    }

    public override float Process (float value, InputControl control) {
      return value / Time.deltaTime;
    }

  }

}
