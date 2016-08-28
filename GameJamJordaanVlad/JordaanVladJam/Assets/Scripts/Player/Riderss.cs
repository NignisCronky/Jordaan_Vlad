using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class Riderss : MonoBehaviour {
    PlayerManager Player;

    public float mLaneChangeSpeed;
    public float ArrowReloadSpeed;
    public GameObject mArrow;

    Animator mAnim;

    public enum RiderType
    {
        Default = 0,
        WildRider,

    }
    public RiderType mRiderType;


    enum MoveInputs
    {
        None = 0,
        Left,
        Right
    }
    MoveInputs mCurInput = 0;
    MoveInputs mBufferedInput = 0;

    void Start()
    {
        mAnim = GetComponent<Animator>();
    }

    public void CheckForInput()
    {
        //Use Buffered
        if (mCurInput == MoveInputs.None && mBufferedInput != MoveInputs.None)
        {
            mCurInput = mBufferedInput;
        }

        //Set Current Or Buffer
        if (Input.GetKeyDown(KeyCode.LeftArrow) && mCurInput==MoveInputs.None)
        {
            mCurInput = MoveInputs.Left;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) && mCurInput == MoveInputs.None)
        {
            mCurInput = MoveInputs.Right;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mBufferedInput = MoveInputs.Left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            mBufferedInput = MoveInputs.Right;
        }

        if (mCurInput == MoveInputs.Left)
        {
            Player.ChangeLaneLeft();
        }
        if (mCurInput == MoveInputs.Right)
        {
            Player.ChangeLaneRight();
        }
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
