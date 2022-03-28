using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipRudder : MonoBehaviour {

  new public Rigidbody rigidbody;

  public float target = 0;
  public float current;
  public float damping = 1;
  public float rollFactor = 1;

  public void Start () {
    rigidbody = GetComponentInParent<Rigidbody>();
  }

  public void FixedUpdate() {
    current = Mathf.Lerp(current, target, Time.deltaTime / (Time.deltaTime + damping));
    rigidbody.AddTorque(Vector3.up * current);
    var r = rigidbody.transform.localEulerAngles;
    r.z = current * rollFactor;
    rigidbody.transform.localEulerAngles = r;
  }

}
