using UnityEngine;
using System.Collections;

public class Chariotss : MonoBehaviour {
    public float mMass;
    public float mWallSpeedLoss;
    public float mCrashSpeedLoss;
    public float mSlowResist;
    public float mMinSpeed;

    public enum ChariotType
    {
        Default = 0,
        TheHeavy,
        WallBanger
    }
    public ChariotType mChariotType;


}
