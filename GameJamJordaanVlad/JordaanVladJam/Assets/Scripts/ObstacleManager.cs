using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ObstacleManager : MonoBehaviour
{
    public List<GameObject> objects;
    public GameObject[] obarr;
	// Use this for initialization
	void Start () {
        obarr = Resources.LoadAll<GameObject>("Obstacles");
        objects = obarr.ToList();
        int i = 5, temp = 0, tir = -1;
        //Area1
        //Ends at 120
        while (i < 115)
        {
            temp = Randomize(0, objects.Count);
            tir = Randomize(0, 5, tir);
            Instantiate(objects[temp], new Vector3(tir, objects[temp].transform.position.y, i), objects[temp].transform.rotation);
            i += Randomize(0, 6);

        }
        i = 125;
        tir = -1;
        //Area2
        //Ends at 240
        while (i < 235)
        {
            temp = Randomize(0, objects.Count);
            tir = Randomize(0, 5, tir);
            Instantiate(objects[temp], new Vector3(tir, objects[temp].transform.position.y, i), objects[temp].transform.rotation);
            i += Randomize(0, 6);
        }
        i = 250;
        tir = -1;
        //Area3
        //Ends at 360
        while (i < 355)
        {
            temp = Randomize(0, objects.Count);
            tir = Randomize(0, 5, tir);
            Instantiate(objects[temp], new Vector3(tir, objects[temp].transform.position.y, i), objects[temp].transform.rotation);
            i += Randomize(0, 8);
        }
    }
	
	// Update is called once per frame
	//void Update () {
	
	//}

    public int Randomize(int fir, int sec, int tir = -1)
    {
        int temp;
        while (true)
        {
            temp = Random.Range(fir, sec);
            if (temp != tir)
                return temp;
        }
    }
}
