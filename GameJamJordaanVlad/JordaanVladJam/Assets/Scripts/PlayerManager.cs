using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody))]
public class PlayerManager : MonoBehaviour
{
    public float mCurrentSpeed;
    public int mHealthMax;
    public int mHealthCurrent;
    public int coins;
    public int CurLane;
    bool IsRoundOver = false;

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
        if (Unit.velocity.z < Horse.mMaxSpeed && !IsRoundOver)
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
        Rider.SetPlayer(this);
        Horse.SetPlayer(this);
        Chariot.SetPlayer(this);
    }

    public void Crash()
    {
        Horse.Crash();
        if (Unit.velocity.z - Chariot.mCrashSpeedLoss < Chariot.mMinSpeed)
        {
            Unit.velocity = new Vector3(Unit.velocity.x, Unit.velocity.y, Chariot.mMinSpeed);
        }
        else
        {
            Unit.velocity = new Vector3(Unit.velocity.x, Unit.velocity.y, Unit.velocity.z - Chariot.mCrashSpeedLoss);
        }
    }

    void ChangeLaneLeft(float time)
    {

    }

    public void OnLossDoThis()
    {
        int temp = PlayerPrefs.GetInt("Coinss");
        temp += coins;
        PlayerPrefs.SetInt("Coinss", temp);
        Rider.LoseAnimation();
        Halt();
    }

    public bool CanItBreakWall(float BreakingPoint)
    {
        return (Chariot.mMass * mCurrentSpeed > BreakingPoint || Chariot.mChariotType == Chariotss.ChariotType.WallBanger);
    }

    public bool CanItBreakObstacle(Chariotss.ChariotType TypeThatBreaks)
    {
        return (TypeThatBreaks == Chariot.mChariotType);
    }

    public void Halt()
    {
        Unit.velocity = Vector3.zero;
        IsRoundOver = true;
    }
}
