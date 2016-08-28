using UnityEngine;
using System.Collections;

public class Horsess : MonoBehaviour {

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

    void Crash()
    {
        if(mCurHorses == 0)
        {
            transform.parent.GetComponent<PlayerManager>().OnLossDoThis();
        }
        else if(mHorseType != HorseType.KronenHorse)
        {
            mCurHorses--;
            mAnim.SetTrigger("LoseHorse");
        }
    }
}
