using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipRudderController : MonoBehaviour {

  public AirshipRudder rudder;

  public float factor = 1;

  public void Start () {
    rudder = GetComponentInParent<AirshipRudder>();
  }

  public void Update() {
    rudder.target = 0;
    if (Input.GetKey(KeyCode.A))
      rudder.target -= factor;
    if (Input.GetKey(KeyCode.D))
      rudder.target += factor;
  }

}
