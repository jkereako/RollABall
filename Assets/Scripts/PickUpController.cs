using UnityEngine;

public class PickUpController: MonoBehaviour {
  void Update() {
    transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
  }
}
