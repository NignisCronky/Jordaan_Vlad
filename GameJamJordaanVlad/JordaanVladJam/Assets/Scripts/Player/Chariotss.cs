using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Chariotss : MonoBehaviour {
    PlayerManager Player;

    public float mMass;
    public float mWallSpeedLoss;
    public float mCrashSpeedLoss;
    public float mSlowResist;
    public float mMinSpeed;

    public void SetPlayer(PlayerManager _Player)
    {
        Player = _Player;
    }

    public enum ChariotType
    {
        Default = 0,
        TheHeavy,
        WallBanger,
        Slick,
        Momentus
    }
    public ChariotType mChariotType;
}
