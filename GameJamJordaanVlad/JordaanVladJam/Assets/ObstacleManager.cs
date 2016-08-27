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
        obarr = Resources.LoadAll<GameObject>("Objects");
        objects = obarr.ToList();
        int i = 5;
        //Area1
        while (i < 160)
        {
            Instantiate(objects[Random.Range(0, objects.Count)], new Vector3(i, 0, Random.Range(0, 5)), Quaternion.identity);
            i += Random.Range(0, 6);
        }
        i = 165;
        //Area2
        while (i < 320)
        {
            Instantiate(objects[Random.Range(0, objects.Count)], new Vector3(i, 0, Random.Range(0, 5)), Quaternion.identity);
            i += Random.Range(0, 6);
        }
        i = 325;
        //Area3
        while (i < 480)
        {
            Instantiate(objects[Random.Range(0, objects.Count)], new Vector3(i, 0, Random.Range(1, 4)), Quaternion.identity);
            i += Random.Range(0, 8);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
