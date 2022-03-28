namespace NNI.Core.Input {
  using UnityEngine;
  using UnityEngine.EventSystems;
  using UnityEngine.InputSystem;
  using NNI.Core.Utils;

  public class CursorLockManager : Singleton<CursorLockManager>, IPointerDownHandler {

    public float sensitivity = 1;

    public Vector2 rawAccum;

    public Vector2 accum;

    public bool locked;

    public Vector2 delta;

    public bool doLock;

    internal void LateUpdate () {
      if (doLock) {
        Lock();
        doLock = false;
      }
      if (locked && UnityEngine.Input.GetKeyDown(KeyCode.Escape))
        Unlock();
      if (locked && Cursor.visible)
        Unlock();
      // delta = (Vector2) Input.mousePosition - lastMousePosition;
      delta = Pointer.current.delta.ReadValue() * sensitivity / Time.deltaTime;
      rawAccum += delta;
      if (!locked)
        delta = Vector2.zero;
      accum += delta;
    }

    void Lock () {
      locked = true;
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
    }

    void Unlock () {
      locked = false;
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
    }

    void IPointerDownHandler.OnPointerDown (PointerEventData eventData) {
      if (GUIUtility.hotControl != 0)
        return;
      GUIUtility.keyboardControl = 0;
      if (eventData.button == 0)
        doLock = true;
    }

  }

}
