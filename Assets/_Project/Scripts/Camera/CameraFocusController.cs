using System.Collections;
using System.Collections.Generic;
using NNI.Core.Input;
using UnityEngine;

public class CameraFocusController : MonoBehaviour {

  public CursorLockManager cursor;

  public float yaw, pitch;

  public float yawFactor, pitchFactor;

  public float pitchLimit;

  public void Start () {
    cursor = CursorLockManager.instance;
  }

  public void FixedUpdate() {
    yaw += cursor.delta.x * yawFactor * Time.fixedDeltaTime;
    pitch += cursor.delta.y * pitchFactor * Time.fixedDeltaTime;
    pitch = Mathf.Clamp(pitch, -pitchLimit, pitchLimit);
    transform.localEulerAngles = new Vector3(pitch, yaw, 0);
  }

}
