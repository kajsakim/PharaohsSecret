using System.Collections;

using UnityEngine;

public class RevealIntroHaiku : MonoBehaviour
{
    
    private int IntroHaiku = 1;
    private int IntroHaikuTips;
    public GameObject HaikuLine1;
    public GameObject HaikuLine2;
    public GameObject HaikuLine3;
    public GameObject HaikuLight;
    public GameObject TipLight;
    public GameObject Tip1;
    public GameObject Tip2;
    public GameObject TipGem1;
    public GameObject TipGem2;
    public GameObject TipRead;

    private void CheckTips()
    {
        if (IntroHaiku == 3)
        {
            if (TipGem1 != null)
                TipGem1.SetActive(true);
            if (TipGem2 != null)
                TipGem2.SetActive(true);
        }
    }
    private void CheckIntroTips()
    { 
        if (IntroHaikuTips == 1)
        {
            TipRead.SetActive(true);
        }

    }
    public void ReadIntroHaiku()
    {
        if (IntroHaiku == 1)
        {
            HaikuLine1.SetActive(true);
            
        }

        else
        {
            HaikuLine1.SetActive(false);
        }

        if (IntroHaiku == 2)
        {
            HaikuLine2.SetActive(true);
            
        }

        else
        {
            HaikuLine2.SetActive(false);
        }

        if (IntroHaiku == 3)
        {
            HaikuLine3.SetActive(true);
            
            
        }

      

    }

    public void ReadIntroHaikuTips()
    {
        if (IntroHaikuTips == 1)
        {
            
            Tip1.SetActive(true);
            
        }

        if (IntroHaikuTips == 2)
        {
            Tip2.SetActive(true);
            
        }
    }

    

    public void IncreaseIntroHaiku()
    {
        
        IntroHaiku++;
        HaikuLight.SetActive(true);
        CheckTips();
    }

    public void IncreaseIntroHaikuTip()
    {
        
        IntroHaikuTips++;
        TipLight.SetActive(true);
        CheckIntroTips();
    }

}
