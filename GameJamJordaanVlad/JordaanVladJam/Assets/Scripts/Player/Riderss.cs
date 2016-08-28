using UnityEngine;
using System.Collections;

public class Riderss : MonoBehaviour {
    public enum RiderType
    {
        Default = 0,
        WildRider,

    }
    public RiderType mRiderType;

    public float mLaneChangeTime;
    public float ArrowReloadSpeed;
    public GameObject mArrow;
    public int LanesToChange;
    public bool LaneWrap;
    enum Inputs
    {
        None = 0,
        Left,
        Right
    }
    Inputs mCurInput = 0;
    Inputs mBufferedInput = 0;

    public void CheckForInput()
    {

    }
}
