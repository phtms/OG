using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public GameObject BulletHole;
    public float delayTime = 8;
    public AudioClip otherClip;
    AudioSource audio;
    private float counter = 0;
    
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0)&& counter > delayTime)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            audio.clip = otherClip;
            audio.Play();
            counter = 0;

            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                Instantiate(BulletHole,hit.point,Quaternion.FromToRotation(Vector3.up,hit.normal));
            }
        }
        counter += Time.deltaTime;
	}
}
