using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FunctionsForShopButtons : MonoBehaviour {

    public GameObject Goldtext;
   public int gold;
	// Use this for initialization
	void Start () {
        gold = PlayerPrefs.GetInt("Coinss");

        if(PlayerPrefs.HasKey("item0")==false)
        {
            PlayerPrefs.SetInt("item0", 0);
        }
        if (PlayerPrefs.HasKey("item1") == false)
        {
            PlayerPrefs.SetInt("item1", 0);
        }
        if (PlayerPrefs.HasKey("item2") == false)
        {
            PlayerPrefs.SetInt("item2", 0);
        }
        if (PlayerPrefs.HasKey("item3") == false)
        {
            PlayerPrefs.SetInt("item3", 0);
        }
        if (PlayerPrefs.HasKey("item4") == false)
        {
            PlayerPrefs.SetInt("item4", 0);
        }
        if (PlayerPrefs.HasKey("item5") == false)
        {
            PlayerPrefs.SetInt("item5", 0);
        }
        if (PlayerPrefs.HasKey("item6") == false)
        {
            PlayerPrefs.SetInt("item6", 0);
        }
        if (PlayerPrefs.HasKey("item7") == false)
        {
            PlayerPrefs.SetInt("item7", 0);
        }
        if (PlayerPrefs.HasKey("item8") == false)
        {
            PlayerPrefs.SetInt("item8", 0);
        }
        if (PlayerPrefs.HasKey("item9") == false)
        {
            PlayerPrefs.SetInt("item9", 0);
        }
        if (PlayerPrefs.HasKey("item10") == false)
        {
            PlayerPrefs.SetInt("item10", 0);
        }
        if (PlayerPrefs.HasKey("item11") == false)
        {
            PlayerPrefs.SetInt("item11", 0);
        }
        if (PlayerPrefs.HasKey("item12") == false)
        {
            PlayerPrefs.SetInt("item12", 0);
        }
        if (PlayerPrefs.HasKey("item13") == false)
        {
            PlayerPrefs.SetInt("item13", 0);
        }
        if (PlayerPrefs.HasKey("item14") == false)
        {
            PlayerPrefs.SetInt("item14", 0);
        }
        if (PlayerPrefs.HasKey("item15") == false)
        {
            PlayerPrefs.SetInt("item15", 0);
        }
        if (PlayerPrefs.HasKey("item16") == false)
        {
            PlayerPrefs.SetInt("item16", 0);
        }
        if (PlayerPrefs.HasKey("item17") == false)
        {
            PlayerPrefs.SetInt("item17", 0);
        }
        if (PlayerPrefs.HasKey("item18") == false)
        {
            PlayerPrefs.SetInt("item18", 0);
        }
        if (PlayerPrefs.HasKey("item19") == false)
        {
            PlayerPrefs.SetInt("item19", 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
        Goldtext.GetComponent<Text>().text = "gold: "+gold;
	}

   public void Trytobuy(int kek)
    {

        switch (kek)
        {
            case 0:
                if (gold >= 200 && PlayerPrefs.GetInt("item0") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item0", 1);
                }
                break;
            case 1:
                if (gold >= 200 && PlayerPrefs.GetInt("item1") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item1", 1);
                }
                break;
            case 2:
                if (gold >= 200 && PlayerPrefs.GetInt("item2") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item2", 1);
                }
                break;
            case 3:
                if (gold >= 200 && PlayerPrefs.GetInt("item3") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item3", 1);
                }
                break;
            case 4:
                if (gold >= 200 && PlayerPrefs.GetInt("item4") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item4", 1);
                }
                break;
            case 5:
                if (gold >= 200 && PlayerPrefs.GetInt("item5") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item5", 1);
                }
                break;
            case 6:
                if (gold >= 200 && PlayerPrefs.GetInt("item6") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item6", 1);
                }
                break;
            case 7:
                if (gold >= 200 && PlayerPrefs.GetInt("item7") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item7", 1);
                }
                break;
            case 8:
                if (gold >= 200 && PlayerPrefs.GetInt("item8") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item8", 1);
                }
                break;
            case 9:
                if (gold >= 200 && PlayerPrefs.GetInt("item9") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item9", 1);
                }
                break;
            case 10:
                if (gold >= 200 && PlayerPrefs.GetInt("item10") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item10", 1);
                }
                break;
            case 11:
                if (gold >= 200 && PlayerPrefs.GetInt("item11") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item11", 1);
                }
                break;
            case 12:
                if (gold >= 200 && PlayerPrefs.GetInt("item12") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item12", 1);
                }
                break;
            case 13:
                if (gold >= 200 && PlayerPrefs.GetInt("item13") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item13", 1);
                }
                break;
            case 14:
                if (gold >= 200 && PlayerPrefs.GetInt("item14") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item14", 1);
                }
                break;
            case 15:
                if (gold >= 200 && PlayerPrefs.GetInt("item15") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item15", 1);
                }
                break;
            case 16:
                if (gold >= 200 && PlayerPrefs.GetInt("item16") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item16", 1);
                }
                break;
            case 17:
                if (gold >= 200 && PlayerPrefs.GetInt("item17") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item17", 1);
                }
                break;
            case 18:
                if (gold >= 200 && PlayerPrefs.GetInt("item18") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item18", 1);
                }
                break;
            case 19:
                if (gold >= 200 && PlayerPrefs.GetInt("item19") == 0)
                {
                    gold -= 200;
                    PlayerPrefs.SetInt("item19", 1);
                }
                break;
            default:
                break;
        }
    }


   public void onEnddothis()
    {
        PlayerPrefs.SetInt("Coinss", gold);
        
    }







    /// <summary>
    /// swtic 0: arrows
    /// switc 1: chariot
    /// switc 2: rider
    /// switc 3: horse
    /// </summary>
    /// <param name="switc"></param>
   public void Setitot1(int switc)
    {
        switch (switc)
        {
            case 0:
                if (PlayerPrefs.GetInt("item0") == 1)
                {
                    PlayerPrefs.SetInt("ArrowType", 0);
                }
                break;
            case 1:
                if (PlayerPrefs.GetInt("item5") == 1)
                {
                    PlayerPrefs.SetInt("ChariotType", 0);
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("item10") == 1)
                {
                    PlayerPrefs.SetInt("RiderType", 0);
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("item15") == 1)
                {
                    PlayerPrefs.SetInt("HorseType", 0);
                }
                break;
            default:
                break;
        }
    }

   public void Setitot2(int switc)
    {
        switch (switc)
        {
            case 0:
                if (PlayerPrefs.GetInt("item1") == 1)
                {
                    PlayerPrefs.SetInt("ArrowType", 1);
                }
                break;
            case 1:
                if (PlayerPrefs.GetInt("item6") == 1)
                {
                    PlayerPrefs.SetInt("ChariotType", 1);
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("item11") == 1)
                {
                    PlayerPrefs.SetInt("RiderType", 1);
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("item16") == 1)
                {
                    PlayerPrefs.SetInt("HorseType", 1);
                }
                break;
            default:
                break;
        }
    }

    public void Setitot3(int switc)
    {
        switch (switc)
        {
            case 0:
                if (PlayerPrefs.GetInt("item2") == 1)
                {
                    PlayerPrefs.SetInt("ArrowType", 2);
                }
                break;
            case 1:
                if (PlayerPrefs.GetInt("item7") == 1)
                {
                    PlayerPrefs.SetInt("ChariotType", 2);
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("item12") == 1)
                {
                    PlayerPrefs.SetInt("RiderType", 2);
                } break;
            case 3:
                if (PlayerPrefs.GetInt("item17") == 1)
                {
                    PlayerPrefs.SetInt("HorseType", 2);
                }
                break;
            default:
                break;
        }
    }

    public void Setitot4(int switc)
    {
        switch (switc)
        {
            case 0:
                if (PlayerPrefs.GetInt("item3") == 1)
                {
                    PlayerPrefs.SetInt("ArrowType", 3);
                }
                break;
            case 1:
                if (PlayerPrefs.GetInt("item8") == 1)
                {
                    PlayerPrefs.SetInt("ChariotType", 3);
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("item13") == 1)
                {
                    PlayerPrefs.SetInt("RiderType", 3);
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("item18") == 1)
                {
                    PlayerPrefs.SetInt("HorseType", 3);
                } break;
            default:
                break;
        }
    }
    public void Setitot5(int switc)
    {
        switch (switc)
        {
            case 0:
                if (PlayerPrefs.GetInt("item4") == 1)
                {
                    PlayerPrefs.SetInt("ArrowType", 4);
                } break;
            case 1:
                if (PlayerPrefs.GetInt("item9") == 1)
                {
                    PlayerPrefs.SetInt("ChariotType", 4);
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("item14") == 1)
                {
                    PlayerPrefs.SetInt("RiderType", 4);
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("item19") == 1)
                {
                    PlayerPrefs.SetInt("HorseType", 4);
                } break;
            default:
                break;
        }
    }
}
