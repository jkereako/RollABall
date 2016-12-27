using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  private Rigidbody player;

  void Start() {
    player = GetComponent<Rigidbody>();
  }

  void FixedUpdate() {
    float horizontalAxis = Input.GetAxis("Horizontal");
    float verticalAxis = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(horizontalAxis, 0.0f, verticalAxis);

    player.AddForce(movement);
  }
}
