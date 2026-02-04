using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class MemoryPuzzle : MonoBehaviour
{
    private int Memory;
    private int BackwardsMemory;
    private int PlanetMemory;
    private int Hotline;
    private int FoodHelp;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
    public GameObject Light8;
    public GameObject Light9;
    public GameObject Memory1;
    public GameObject Memory2;
    public GameObject Memory3;
    public GameObject Memory4;
    public GameObject Memory5;
    public GameObject Memory6;
    public GameObject Memory7;
    public GameObject Memory8;
    public GameObject Memory9;
    public GameObject RedWall;
    public GameObject BlueBoxSpawner;
    public GameObject YellowBoxSpawner;
    private RevealHaiku2 Increase;
    public GameObject YellowGem;
    public GameObject BlueGem;
    public GameObject HintGem1;
    public GameObject HintGem2;
    public GameObject PuzzleReset;

    public float Waiting;
    void Start()
    {

    }

    void CheckMemories()
    {
        if (Memory == 9)
        {
            RedWall.SetActive(false);
        }

        if (BackwardsMemory == 9)
        {
            BlueBoxSpawner.SetActive(true);
        }

        if (PlanetMemory == 8)
        {
            YellowBoxSpawner.SetActive(true);
        }

        if (Hotline == 4 && BlueGem == null)
        {
            HintGem1.SetActive(true);
        }

        if (FoodHelp == 3 && YellowGem == null)
        {
            HintGem2.SetActive(true);
        }
    }

    IEnumerator MemoryLights()
    {
        Light1.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light1.SetActive(false);
        Light2.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light2.SetActive(false);
        Light3.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light3.SetActive(false);
        Light4.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light4.SetActive(false);
        Light5.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light5.SetActive(false);
        Light6.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light6.SetActive(false);
        Light7.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light7.SetActive(false);
        Light8.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light8.SetActive(false);
        Light9.SetActive(true);
        yield return new WaitForSeconds(Waiting);
        Light9.SetActive(false);
        Memory1.SetActive(true);
        Memory2.SetActive(true);
        Memory3.SetActive(true);
        Memory4.SetActive(true);
        Memory5.SetActive(true);
        Memory6.SetActive(true);
        Memory7.SetActive(true);
        Memory8.SetActive(true);
        Memory9.SetActive(true);
        PuzzleReset.SetActive(true);
    }

    public void StartMemoryLights()
    {
        StopAllCoroutines();
        Memory = 0;
        BackwardsMemory = 0;
        PlanetMemory = 0;
        Hotline = 0;
        FoodHelp = 0;
        Memory1.SetActive(false);
        Memory2.SetActive(false);
        Memory3.SetActive(false);
        Memory4.SetActive(false);
        Memory5.SetActive(false);
        Memory6.SetActive(false);
        Memory7.SetActive(false);
        Memory8.SetActive(false);
        Memory9.SetActive(false);
        Light1.SetActive(false);
        Light2.SetActive(false);
        Light3.SetActive(false);
        Light4.SetActive(false);
        Light5.SetActive(false);
        Light6.SetActive(false);
        Light7.SetActive(false);
        Light8.SetActive(false);
        Light9.SetActive(false);
        StartCoroutine(MemoryLights());
    }

    public void ResetPuzzle()
    {
        Memory = 0;
        BackwardsMemory = 0;
        PlanetMemory = 0;
        Hotline = 0;
        FoodHelp = 0;
        Memory1.SetActive(true);
        Memory2.SetActive(true);
        Memory3.SetActive(true);
        Memory4.SetActive(true);
        Memory5.SetActive(true);
        Memory6.SetActive(true);
        Memory7.SetActive(true);
        Memory8.SetActive(true);
        Memory9.SetActive(true);
        Light1.SetActive(false);
        Light2.SetActive(false);
        Light3.SetActive(false);
        Light4.SetActive(false);
        Light5.SetActive(false);
        Light6.SetActive(false);
        Light7.SetActive(false);
        Light8.SetActive(false);
        Light9.SetActive(false);
    }

    public void OneMercury()
    {
        if (Memory == 0)
        {
            Memory ++;
        }

        else
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 8)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 4)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        if (Hotline == 3)
        {
            Hotline++;
        }

        else
        {
            Hotline += 1000;
        }

        FoodHelp += 1000;

            CheckMemories();
    }

    public void TwoVenus()
    {
        if (Memory == 1)
        {
            Memory ++;
        }

        else 
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 7)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 2)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        if (Hotline == 0)
        {
            Hotline++;
        }

        else
        {
            Hotline += 1000;
        }

        if (FoodHelp == 1)
        {
            FoodHelp++;
        }

        else
        {
            FoodHelp += 1000;
        }

    }

    public void ThreeEarth()
    {
        if (Memory == 2)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 6)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 5)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        Hotline += 1000;

        FoodHelp += 1000;
    }

    public void FourMars()
    {
        if (Memory == 3)
        {
            Memory++;
        }

        else 
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 5)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 0)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        Hotline += 1000;

        if (FoodHelp == 2)
        {
            FoodHelp++;
        }

        else
        {
            FoodHelp += 1000;
        }

        CheckMemories();
    }

    public void FiveJupiter()
    {
        if (Memory == 4)
        {
            Memory++;
        }

        else 
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 4)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 6)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        Hotline += 1000;

        FoodHelp += 1000;
    }

    public void SixSaturn()
    {
        if (Memory == 5)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 3)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 1)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        Hotline += 1000;

        FoodHelp += 1000;
    }

    public void SevenUranus()
    {
        if (Memory == 6)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 2)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 3)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        if (Hotline == 1)
        {
            Hotline++;
        }

        else
        {
            Hotline += 1000;
        }

        FoodHelp += 1000;
    }

    public void EightNeptune()
    {
        if (Memory == 7)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 1)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (PlanetMemory == 7)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
        }

        Hotline += 1000;

        if (FoodHelp == 0)
        {
            FoodHelp++;
        }

        else
        {
            FoodHelp += 1000;
        }

            CheckMemories();
    }

    public void NinePluto()
    {
        if (Memory == 8)
        {
            Memory++;
        }

        else 
        {
            Memory += 1000;
        }

        if (BackwardsMemory == 0)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
        }

        if (Hotline == 2)
        {
            Hotline++;
        }

        else
        {
            Hotline += 1000;
        }

            FoodHelp += 1000;

        CheckMemories();
    }
}
