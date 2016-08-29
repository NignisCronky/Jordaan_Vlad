using UnityEngine;
using System.Collections;

public class Arrowss : MonoBehaviour {
    bool Piercing;
    float ShotDistance;
    public float ShotSpeed;

    public Rigidbody bod;
    public float speed;

    // Use this for initialization
    void Start () {
        if(bod == null)
        bod = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        bod.velocity = gameObject.transform.up * ShotSpeed;
    }
}
