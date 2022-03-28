namespace NNI.Core {
  using UnityEngine;

  public class ConstantTransform : MonoBehaviour {

    public Space space;

    public Vector3 translate;
    public Vector3 relativeTranslate;

    public Vector3 rotate;
    public Vector3 relativeRotate;

    internal void Update () {
      transform.Translate(translate * Time.deltaTime, space);
      transform.Translate(relativeTranslate * Time.deltaTime, space);
      transform.Rotate(rotate * Time.deltaTime, space);
      transform.Rotate(relativeRotate * Time.deltaTime, space);
    }

  }

}
