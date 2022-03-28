using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipMotor : MonoBehaviour {

  new public Rigidbody rigidbody;

  public float target = 0;
  public float current;
  public float damping = 1;

  public float pitchFactor = 1;

  public Transform[] props;
  public float propAngle = 0;
  public float propFactor = 1;

  public void Start () {
    rigidbody = GetComponentInParent<Rigidbody>();
  }

  public void FixedUpdate() {
    current = Mathf.Lerp(current, target, Time.deltaTime / (Time.deltaTime + damping));
    var forward = Vector3.ProjectOnPlane(transform.forward, Vector3.up).normalized;
    rigidbody.AddForce(forward * current);
    var r = rigidbody.transform.localEulerAngles;
    r.x = current * pitchFactor;
    rigidbody.transform.localEulerAngles = r;
    propAngle += current * propFactor;
    foreach (var prop in props)
      prop.localEulerAngles = new Vector3(propAngle, 0, 0);
  }

}
