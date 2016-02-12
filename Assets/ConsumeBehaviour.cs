using UnityEngine;
using System.Collections;

public class ConsumeBehaviour : MonoBehaviour {
	public Vector3 ScaleIncrease;
	public Vector3 PositionIncrease;
	public Vector3 CameraPositionIncrease;
	public Camera PlayerCamera;

	void OnTriggerEnter(Collider collider) {
		this.transform.localScale += ScaleIncrease;
		this.transform.localPosition += PositionIncrease;
		PlayerCamera.transform.localPosition += CameraPositionIncrease;
	}
}
