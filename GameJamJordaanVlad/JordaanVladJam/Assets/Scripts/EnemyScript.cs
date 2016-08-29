using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    GameObject player, arrow;
    public float cooldown, range;
    float firenext;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        arrow = Resources.Load<GameObject>("Projectiles/Arrow");
        firenext = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

        if (range == 0)
            range = 20;
        if (cooldown == 0)
            cooldown = 4;


        if (firenext <= Time.time)
        {
            if (Vector3.Distance(gameObject.transform.position, player.transform.position) < range)
            {
                FireArrow();
                firenext = cooldown + Time.time;
            }
        }
	}
    void FireArrow()
    {
        //GameObject temparrow = Instantiate(arrow, gameObject.transform.position, arrow.transform.rotation) as GameObject;
        Instantiate(arrow, new Vector3(gameObject.transform.position.x, arrow.transform.position.y, gameObject.transform.position.z - .5f), arrow.transform.rotation);
    }
}
