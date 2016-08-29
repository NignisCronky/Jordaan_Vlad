using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class Horsess : MonoBehaviour
{
    PlayerManager Player;

    public float mAcceleration;
    public float mMaxSpeed;
    public float mMaxSpeedLostInCrash;
    public float mAccelerationLostInCrash;

    public int mInitialHorses;
    public int mCurHorses;

    Animator mAnim;

    public enum HorseType
    {
        Default = 0,
        KronenHorse,
        MareyAllen
    }
    public HorseType mHorseType;

    void Start()
    {
        mAnim = GetComponent<Animator>();
    }

    public void Crash()
    {
        if (mCurHorses == 0)
        {
            Player.OnLossDoThis();
        }
        else if (mHorseType != HorseType.KronenHorse)
        {
            mCurHorses--;
            mAnim.SetTrigger("LoseHorse");
        }
    }

    public void LoseHorse()
    {
        mMaxSpeed -= mMaxSpeedLostInCrash;
        mAcceleration -= mAccelerationLostInCrash;
    }

    public void SetPlayer(PlayerManager _Player)
    {
        Player = _Player;
    }

}
