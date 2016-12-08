using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectionGold : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
        Points.score++;
		Destroy(this.gameObject);

	}
}
