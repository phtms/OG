using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ammo : MonoBehaviour {
	public static int ammo, ammoCurrent;
	Text ammoText;  

	// Use this for initialization
	void Start () {
		ammoText = GetComponent<Text>();
		ammo = 0;
		ammoCurrent = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ammoText.text = ammoCurrent + " | " + ammo;
	}
}
