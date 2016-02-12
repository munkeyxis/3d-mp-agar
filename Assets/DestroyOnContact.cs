using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		Destroy(this.gameObject);
	}
}
