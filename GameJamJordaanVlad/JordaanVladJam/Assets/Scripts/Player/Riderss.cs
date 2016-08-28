using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class Riderss : MonoBehaviour {
    PlayerManager Player;

    public float mLaneChangeTime;
    public float ArrowReloadSpeed;
    public GameObject mArrow;
    public int LanesToChange;
    public bool LaneWrap;

    Animator mAnim;

    public enum RiderType
    {
        Default = 0,
        WildRider,

    }
    public RiderType mRiderType;


    enum Inputs
    {
        None = 0,
        Left,
        Right
    }
    Inputs mCurInput = 0;
    Inputs mBufferedInput = 0;

    void Start()
    {
        mAnim = GetComponent<Animator>();
    }

    public void CheckForInput()
    {

    }

    public void LoseAnimation()
    {
        mAnim.SetBool("Lose", true);
    }

    public void RoundOver()
    {
        SceneManager.LoadScene("testbench");
    }

    public void SetPlayer(PlayerManager _Player)
    {
        Player = _Player;
    }

}
