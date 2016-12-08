using UnityEngine;
using System.Collections;

public class doorcloseopen : MonoBehaviour {
	private Animation anim;
	private bool doorOpen = false;
	private Ray ray;
	private RaycastHit hit;
	private float distance = 2.0f;
	public Collider coll;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
		coll = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("e")){
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				if (coll.Raycast (ray, out hit, 5.0F)) {
					this.anim.Play ("door1open");
					Debug.Log ("test");
				}
			} 

		}
	}
