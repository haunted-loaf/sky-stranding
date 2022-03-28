using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AirshipAimMode : MonoBehaviour {

  new public CinemachineVirtualCamera camera;

  public CameraFocusController focus;

  public GameObject grapple;

  public void Enable () {
    camera.Priority = 10;
    focus.enabled = true;
    grapple.SetActive(true);
  }

  public void Disable () {
    camera.Priority = 0;
    focus.enabled = false;
    grapple.SetActive(false);
  }

}
