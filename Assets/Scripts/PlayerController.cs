﻿using UnityEngine;

public class PlayerController : MonoBehaviour {
  // Public member variables are visible in the Unity editor. These are analogous to IBOutlets in
  // Xcode/InterfaceBuilder
  public float speed;

  // The default access modifier is `private`.
  Rigidbody player;

  void Start() {
    player = GetComponent<Rigidbody>();
  }

  // `FixedUpdate` is used for physics computations
  void FixedUpdate() {
    float horizontalAxis = Input.GetAxis("Horizontal");
    float verticalAxis = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(horizontalAxis, 0.0f, verticalAxis);

    player.AddForce(movement * speed);
  }

  void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("Pick up")) {
      other.gameObject.SetActive(false);
    }
  }
}
