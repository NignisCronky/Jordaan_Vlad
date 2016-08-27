using UnityEngine;
using System.Collections;



public class PlayerManager : MonoBehaviour {

    public float mCurrentSpeed;
    public int mHealthMax;
    public int mHealthCurrent;
    public int coins;



    public GameObject[] Riders;
    public GameObject[] Chariots;
    public GameObject[] Horses;

    GameObject Rider;
    GameObject Horse;
    GameObject Chariot;
    GameObject Map;
    
    
	void Start () {
	
	}

	void Update () {
	
	}
    void FixedUpdate()
    {
        //0.02 is the interval
    }

    void AssignOnStart()
    {
        if(PlayerPrefs.HasKey("Coinss")==false)
        {
            PlayerPrefs.SetInt("Coinss", 0);
        }
        if(PlayerPrefs.HasKey("ChariotType")==false)
        {
            PlayerPrefs.SetInt("ChariotType", 0);
        }
        if (PlayerPrefs.HasKey("RiderType") == false)
        {
            PlayerPrefs.SetInt("RiderType", 0);
        }
        if (PlayerPrefs.HasKey("HorseType") == false)
        {
            PlayerPrefs.SetInt("HorseType", 0);
        }

        Rider = Riders[PlayerPrefs.GetInt("RiderType")];
        Horse = Horses[PlayerPrefs.GetInt("HorseType")];
        Chariot = Chariots[PlayerPrefs.GetInt("ChariotType")];

    }
    /// <summary>
    /// This handels updating the speed buy 1/12 of the acceleration rate
    /// </summary>
    void SpeedUpdate()
    {

    }

    void ShootArrow()
    {

    }


    void OnLossDoThis()
    {
        int temp = PlayerPrefs.GetInt("Coinss");
        temp += coins;
        PlayerPrefs.SetInt("Coinss", temp);
    }

}
