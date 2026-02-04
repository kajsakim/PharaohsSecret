
using System.Collections;
using UnityEngine;

public class RevealHaiku : MonoBehaviour
{
    private int Haiku = 0;
    private int HaikuTips;
    private int SpawnTipGem;
    public GameObject HaikuSecret;
    public GameObject HaikuLine1;
    public GameObject HaikuLine2;
    public GameObject HaikuLine3;
    public GameObject Hint;
    public GameObject Definition;
    public GameObject Light;
    public GameObject Tip1;
    public GameObject Tip2;
    public GameObject TipLight;
    public GameObject TipRead;
    public GameObject TipGem1;
    public GameObject TipGem2;
    public GameObject TipHaiku;
    

    IEnumerator TriggerReveal()
    {
        
        yield return new WaitForSeconds(9);
        SpawnTipGem = 10;
        yield return new WaitForSeconds(2);
        SpawnTipGem = 0;
    }

    public void CheckTriggerReveal()
    {
        if (Haiku == 3)
        {
            StartCoroutine(TriggerReveal());
        }
    }

    private void CheckTipRead()
    {
        if (Haiku == 3)
        {
            TipRead.SetActive(true);
        }
    }

    private void CheckTipRead2()
    {
        if (HaikuTips == 1)
        TipGem2.SetActive(true);
    }

    
   
    public void Read()
    {
        if (Haiku == 0)
        {
            HaikuSecret.SetActive(true);
            
        }

        else
        {
            HaikuSecret.SetActive(false);
        }

        if (Haiku == 1)
        {
            HaikuLine1.SetActive(true);
            
        }

        else
        {
            HaikuLine1.SetActive(false);
        }

        if (Haiku == 2)
        {
            HaikuLine2.SetActive(true);
            
        }

        else
        {
            HaikuLine2.SetActive(false);
        }

        if (Haiku == 3)
        {
            HaikuLine3.SetActive(true);
            
        }

        
    }

    public void ReadHaikuTips()
    {
        if (HaikuTips == 0)
        {
            TipHaiku.SetActive(true);
        }
        if (HaikuTips == 1)
        {
            
            Tip1.SetActive(true);
            
        }

        if (HaikuTips == 2)
        {
            Tip2.SetActive(true);
            
        }

        if (SpawnTipGem == 10)
        {
            TipGem1.SetActive(true);
        }
    }



    public void IncreaseHaiku()
    {
        Haiku++;
        Light.SetActive(true);
        CheckTipRead();
    }

    public void IncreaseHaikuTips()
    {
        HaikuTips++;
        TipLight.SetActive(true);
        CheckTipRead2();
    }

   

}
