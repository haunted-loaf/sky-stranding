using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AirshipFlightMode : MonoBehaviour {

  new public CinemachineVirtualCamera camera;

  public CameraFocusController focus;

  public void Enable () {
    camera.Priority = 10;
    focus.enabled = true;
  }

  public void Disable () {
    camera.Priority = 0;
    focus.enabled = false;
  }

}
