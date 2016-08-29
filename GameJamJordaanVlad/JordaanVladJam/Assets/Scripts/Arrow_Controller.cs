using UnityEngine;
using System.Collections;

public class Arrow_Controller : MonoBehaviour {
    Rigidbody bod;
    public float speed, lifetime;
	// Use this for initialization
	void Start () {
        bod = gameObject.GetComponent<Rigidbody>();
        lifetime += Time.time;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //GetComponent<Rigidbody>().velocity = gameObject.transform.right * -speed;
        bod.velocity = gameObject.transform.up * speed;
        if (lifetime <= Time.time)
            gameObject.SetActive(false);
    }
}
