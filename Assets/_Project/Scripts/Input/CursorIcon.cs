namespace NNI.Core.Input {
  using UnityEngine;

  public class CursorIcon : MonoBehaviour {

    public Sprite sprite;

    internal void OnEnable () {
      if (sprite)
        Cursor.SetCursor(sprite.texture, new Vector2(sprite.pivot.x, sprite.texture.height - sprite.pivot.y), CursorMode.Auto);
    }

  }

}
