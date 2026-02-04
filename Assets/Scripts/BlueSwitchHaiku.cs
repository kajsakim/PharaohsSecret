using UnityEngine;

public class BlueSwitchHaiku : MonoBehaviour
{
    private int BlueHaiku = 0;

    public GameObject HaikuLine1;
    public GameObject BlueSpawn;
    public GameObject BlueLightIntro;


    private void CheckBlueHaiku()
    {
        if (BlueHaiku == 3)
        {
            BlueLightIntro.SetActive(true);
        }
    }

    public void ReadBlueHaiku()
    {
        if (BlueHaiku < 3)
        {
            HaikuLine1.SetActive(true);
            

        }

        else
        {
            HaikuLine1.SetActive(false);
            BlueSpawn.SetActive(true);
        }

        
        
       

    }



    public void IncreaseBlueHaiku()
    {
        BlueHaiku++;
        CheckBlueHaiku();
    }
}
