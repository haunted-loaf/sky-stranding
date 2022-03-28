using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipModeSwitcher : MonoBehaviour {

  public AirshipFlightMode  flightMode;
  public AirshipAimMode aimMode;

  public void Start () {
    flightMode.Enable();
    aimMode.Disable();
  }

  public void Update() {
    if (Input.GetKeyDown(KeyCode.Alpha1)) {
      flightMode.Enable();
      aimMode.Disable();
    }
    if (Input.GetKeyDown(KeyCode.Alpha2)) {
      flightMode.Disable();
      aimMode.Enable();
    }
  }

}
