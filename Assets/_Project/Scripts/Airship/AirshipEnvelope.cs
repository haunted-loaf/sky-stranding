using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipEnvelope : MonoBehaviour {

  new public Rigidbody rigidbody;

  public float target = 0;
  public float current;
  public float damping = 1;

  public void Start () {
    rigidbody = GetComponentInParent<Rigidbody>();
  }

  public void FixedUpdate() {
    current = Mathf.Lerp(current, target, Time.deltaTime / (Time.deltaTime + damping));
    rigidbody.AddForce(Vector3.up * current);
  }

}
