using UnityEngine;

public class CameraController : MonoBehaviour {
  public GameObject player;

  Vector3 offset;

  // Use this for initialization
  void Start() {
    offset = transform.position - player.transform.position;
  }
	
  // `LateUpdate` invokes after `Update`.
  void LateUpdate() {
    transform.position = player.transform.position + offset;
  }
}
