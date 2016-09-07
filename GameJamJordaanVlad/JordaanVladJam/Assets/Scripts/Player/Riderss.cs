using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class Riderss : MonoBehaviour {
    PlayerManager Player;

    public float mLaneChangeSpeed;
    public float ArrowReloadSpeed;
    float Reload;
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
        Reload = ArrowReloadSpeed;
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
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) && mCurInput==MoveInputs.None)
        {
            mCurInput = MoveInputs.Left;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) && mCurInput == MoveInputs.None)
        {
            mCurInput = MoveInputs.Right;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            mBufferedInput = MoveInputs.Left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
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

        if (Reload >= ArrowReloadSpeed)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }
    }

     void Shoot()
    {
        Arrowss temp = ((GameObject)Instantiate(mArrow, transform.position, Quaternion.LookRotation(Vector3.down, Vector3.up), Player.transform)).GetComponent<Arrowss>();
        temp.SetRider(gameObject);
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
