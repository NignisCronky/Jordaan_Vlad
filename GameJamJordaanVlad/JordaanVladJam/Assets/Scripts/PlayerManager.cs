using UnityEngine;
using System.Collections;



public class PlayerManager : MonoBehaviour
{

    public float mCurrentSpeed;
    public int mHealthMax;
    public int mHealthCurrent;
    public int coins;
    public int CurLane;


    public Riderss[] Riders;
    public Chariotss[] Chariots;
    public Horsess[] Horses;
    public GameObject[] Arrows;

    GameObject RiderPrefab;
    GameObject HorsePrefab;
    GameObject ChariotPrefab;

    Riderss Rider;
    Horsess Horse;
    Chariotss Chariot;
    ObstacleManager Map;
    Rigidbody Unit;

    void Start()
    {
        Unit = gameObject.GetComponent<Rigidbody>();
        AssignOnStart();
    }

    void Update()
    {
        Rider.CheckForInput();
    }

    void FixedUpdate()
    {
        //0.02 is the interval
        if (Unit.velocity.z < Horse.mMaxSpeed)
        {
            Unit.velocity = new Vector3(Unit.velocity.x, Unit.velocity.y, Unit.velocity.z + (Horse.mAcceleration));
        }
    }

    void AssignOnStart()
    {
        if (PlayerPrefs.HasKey("Coinss") == false)
        {
            PlayerPrefs.SetInt("Coinss", 0);
        }
        if (PlayerPrefs.HasKey("ChariotType") == false)
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
        Rider.mArrow = Arrows[PlayerPrefs.GetInt("ArrowType")];
        Horse = Horses[PlayerPrefs.GetInt("HorseType")];
        Chariot = Chariots[PlayerPrefs.GetInt("ChariotType")];
    }

    public void Crash()
    {

    }

    void ChangeLaneLeft(float time)
    {

    }

    public void OnLossDoThis()
    {
        int temp = PlayerPrefs.GetInt("Coinss");
        temp += coins;
        PlayerPrefs.SetInt("Coinss", temp);
    }

    public bool CanItBreakWall(float BreakingPoint)
    {
        return (Chariot.mMass * mCurrentSpeed > BreakingPoint || Chariot.mChariotType == Chariotss.ChariotType.WallBanger);      
    }

    public bool CanItBreakObstacle(Chariotss.ChariotType TypeThatBreaks)
    {
        return (TypeThatBreaks == Chariot.mChariotType);
    }
}
