using System.Collections;
using UnityEngine;

public class RevealHaiku2 : MonoBehaviour
{
    private int Haiku2 = 0;
    private int Haiku2Tips;
    private int SecondHaiku2Tips;

    public GameObject HaikuSecret;
    public GameObject HaikuLine1;
    public GameObject HaikuLine2;
    public GameObject HaikuLine3;
    public GameObject Tip1;
    public GameObject Tip2;
    public GameObject Light;
    public GameObject TipHaiku2;
    public GameObject TipLight2;
    public GameObject TipHaiku3;

    public void Read()
    {
        if (Haiku2 == 0)
        {
            HaikuSecret.SetActive(true);

        }

        else
        {
            HaikuSecret.SetActive(false);
        }

        if (Haiku2 == 1)
        {
            HaikuLine1.SetActive(true);

        }

        else
        {
            HaikuLine1.SetActive(false);
        }

        if (Haiku2 == 2)
        {
            HaikuLine2.SetActive(true);

        }

        else
        {
            HaikuLine2.SetActive(false);
        }

        if (Haiku2 == 3)
        {
            HaikuLine3.SetActive(true);
            
        }

        if (Haiku2 == 4)
        {
            HaikuLine3.SetActive(true);
        }
    }

    public void ReadHaikuTips()
    {
        if (Haiku2Tips == 0)
        {
            TipHaiku2.SetActive(true);
        }

        else
        {
            TipHaiku2.SetActive(false);
        }
        if (Haiku2Tips == 1)
        {

            Tip1.SetActive(true);

        }

        else
        {
            Tip1.SetActive(false);
        }

        if (SecondHaiku2Tips == 1)
        {
            Haiku2Tips = 3;
            TipHaiku2.SetActive(false);
            Tip1.SetActive(false);
            TipHaiku3.SetActive(true);
        }

        else
        {
            TipHaiku3.SetActive(false);
        }

        if (SecondHaiku2Tips == 2)
        {
            Tip2.SetActive(true);

        }

        else
        {
            Tip2.SetActive(false);
        }

        
    }





    public void IncreaseHaiku2()
    {
        Haiku2++;
        Light.SetActive(true);
    }

    public void IncreaseHaiku2Tips()
    {
        Haiku2Tips++;
        TipLight2.SetActive(true);
    }

    public void IncreaseSecondHaiku2Tips()
    {
        SecondHaiku2Tips++;
        TipLight2.SetActive(true);
    }


}
