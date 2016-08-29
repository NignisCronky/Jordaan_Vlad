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
        ZooLander
    }
    public RiderType mRiderType;


    enum MoveInputs
    {
        None = 0,
        Left,
        Right,
        Centering
    }
    MoveInputs mCurInput = 0;
    MoveInputs mBufferedInput = 0;

    void Start()
    {
        mAnim = GetComponent<Animator>();
    }

    public void CheckForInput()
    {
        if (mCurInput == MoveInputs.Centering)
        {
            return;
        }

        //Use Buffered
        if (mCurInput == MoveInputs.None && mBufferedInput != MoveInputs.None)
        {
            mCurInput = mBufferedInput;
            mBufferedInput = MoveInputs.None;
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
        if (!Player.ChangingLanes)
        {
            if (mCurInput == MoveInputs.Left)
            {
                if (mRiderType == RiderType.WildRider)
                {
                    Player.ChangeToLane(Player.CurLane - 2 % (Player.MaxLaneAvailable - Player.MinLaneAvailable));
                }
                else if(mRiderType == RiderType.ZooLander)
                {
                    mCurInput = MoveInputs.None;
                }
                else
                {
                    Player.ChangeToLane(Player.CurLane - 1);
                }

            }
            else if (mCurInput == MoveInputs.Right)
            {
                if (mRiderType == RiderType.WildRider)
                {
                    Player.ChangeToLane(Player.CurLane + 2 % (Player.MaxLaneAvailable - Player.MinLaneAvailable));
                }
                else if (mRiderType == RiderType.ZooLander)
                {
                    Player.ChangeToLane(Player.CurLane + 1 % (Player.MaxLaneAvailable - Player.MinLaneAvailable));
                }
                else
                {
                    Player.ChangeToLane(Player.CurLane + 1);
                }
            } 
        }
    }

    public void LaneChangeComplete()
    {
        mCurInput = MoveInputs.None;
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
