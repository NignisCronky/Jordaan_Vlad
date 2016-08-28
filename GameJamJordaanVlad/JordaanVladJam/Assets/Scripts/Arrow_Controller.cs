using UnityEngine;
using System.Collections;

public class Arrow_Controller : MonoBehaviour {
    Rigidbody bod;
    public float speed;
	// Use this for initialization
	void Start () {
        bod = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //GetComponent<Rigidbody>().velocity = gameObject.transform.right * -speed;
        bod.velocity = gameObject.transform.up * speed;
    }
}
