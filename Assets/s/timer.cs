using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public float time;
	Text timeText;   
	// Use this for initialization
	void Start () {
		timeText = GetComponent<Text>();
		time = 1;
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		//Debug.Log(time);

		timeText.text = "" + (int)time;	
	}
}
