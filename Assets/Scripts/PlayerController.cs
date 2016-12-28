using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
  // Public member variables are visible in the Unity editor. These are analogous to IBOutlets in
  // Xcode/InterfaceBuilder
  public float speed;
  public Text countText;
  public Text gameWonText;

  // The default access modifier is `private`.
  Rigidbody player;
  int count;

  void Start() {
    count = 0;
    SetCountText();
    gameWonText.text = "";
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
      count += 1;
      SetCountText();
      other.gameObject.SetActive(false);
    }
  }

  void SetCountText() {
    countText.text = "Count :" + count;

    if (count >= 12) {
      gameWonText.text = "You won!";
    }
  }
}
