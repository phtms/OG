using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmmoCollection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (Ammo.ammo < 10) {
			Ammo.ammo++;
			Destroy (this.gameObject);
		}

	}
}
