using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipMotorController : MonoBehaviour {

  public AirshipMotor motor;

  public float factor = 1;

  public void Start () {
    motor = GetComponentInParent<AirshipMotor>();
  }

  public void Update() {
    motor.target = 0;
    if (Input.GetKey(KeyCode.W))
      motor.target += factor;
    if (Input.GetKey(KeyCode.S))
      motor.target -= factor;
  }

}
