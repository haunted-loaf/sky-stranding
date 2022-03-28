using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipEnvelopeController : MonoBehaviour {

  public AirshipEnvelope envelope;

  public float factor = 1;

  public void Start () {
    envelope = GetComponentInParent<AirshipEnvelope>();
  }

  public void Update() {
    envelope.target = 0;
    if (Input.GetKey(KeyCode.R))
      envelope.target += factor;
    if (Input.GetKey(KeyCode.F))
      envelope.target -= factor;
  }

}
