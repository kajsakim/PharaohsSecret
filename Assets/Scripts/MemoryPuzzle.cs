using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class MemoryPuzzle : MonoBehaviour
{
    private int Memory;
    private int BackwardsMemory;
    private int PlanetMemory;

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
    public GameObject FirstMemory;
    public GameObject SecondMemory;
    public GameObject ThirdMemory;
    public GameObject ExitDoor;
    public GameObject PuzzleReset;

    public float Waiting;
    void Start()
    {

    }

    void CheckMemories()
    {
        if (Memory == 9)
        {
            SecondMemory.SetActive(true);
            FirstMemory.SetActive(false);
        }

        if (BackwardsMemory == 9 && GameObject.Find("BackwardsMemory"))
        {
            ThirdMemory.SetActive(true);
            SecondMemory.SetActive(false);
        }

        if (PlanetMemory == 8 && GameObject.Find("PlanetMemory"))
        {
            ExitDoor.SetActive(false);
            ThirdMemory.SetActive(false);
        }

        if (Memory >= 999 && GameObject.Find("FirstMemory"))
        {
            StopAllCoroutines();
            ResetPuzzle();
            Light1.SetActive(false);
            Light2.SetActive(false);
            Light3.SetActive(false);
            Light4.SetActive(false);
            Light5.SetActive(false);
            Light6.SetActive(false);
            Light7.SetActive(false);
            Light8.SetActive(false);
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
        }

        if (BackwardsMemory >= 999 && GameObject.Find("BackwardsMemory"))
        {
            StopAllCoroutines();
            ResetPuzzle();
            Light1.SetActive(false);
            Light2.SetActive(false);
            Light3.SetActive(false);
            Light4.SetActive(false);
            Light5.SetActive(false);
            Light6.SetActive(false);
            Light7.SetActive(false);
            Light8.SetActive(false);
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
        }

        if (PlanetMemory >= 999 && GameObject.Find("PlanetMemory"))
        {
            StopAllCoroutines();
            ResetPuzzle();
            Light1.SetActive(false);
            Light2.SetActive(false);
            Light3.SetActive(false);
            Light4.SetActive(false);
            Light5.SetActive(false);
            Light6.SetActive(false);
            Light7.SetActive(false);
            Light8.SetActive(false);
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
        PuzzleReset.SetActive(true);
    }

    public void StartMemoryLights()
    {
        StopAllCoroutines();
        Memory = 0;
        BackwardsMemory = 0;
        PlanetMemory = 0;
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
        StopAllCoroutines();
        Memory1.SetActive(false);

        if (Memory == 0)
        {
            Memory ++;
        }

        else
        {
            Memory += 1000;
            Light1.SetActive(false);
        }

        if (BackwardsMemory == 8)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light1.SetActive(false);
        }

        if (PlanetMemory == 4)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light1.SetActive(false);
        }

       

            CheckMemories();
    }

    public void TwoVenus()
    {
        StopAllCoroutines();
        Memory2.SetActive(false);

        if (Memory == 1)
        {
            Memory ++;
        }

        else 
        {
            Memory += 1000;
            Light2.SetActive(false);
        }

        if (BackwardsMemory == 7)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light2.SetActive(false);
        }

        if (PlanetMemory == 2)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light2.SetActive(false);
        }

        CheckMemories();

    }

    public void ThreeEarth()
    {
        StopAllCoroutines();
        Memory3.SetActive(false);

        if (Memory == 2)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
            Light3.SetActive(false);
        }

        if (BackwardsMemory == 6)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light3.SetActive(false);
        }

        if (PlanetMemory == 5)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light3.SetActive(false);
        }

        CheckMemories();
    }

    public void FourMars()
    {
        StopAllCoroutines();
        Memory4.SetActive(false);

        if (Memory == 3)
        {
            Memory++;
        }

        else 
        {
            Memory += 1000;
            Light4.SetActive(false);
        }

        if (BackwardsMemory == 5)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light4.SetActive(false);
        }

        if (PlanetMemory == 0)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light4.SetActive(false);
        }

       

        CheckMemories();
    }

    public void FiveJupiter()
    {
        StopAllCoroutines();
        Memory5.SetActive(false);

        if (Memory == 4)
        {
            Memory++;
        }

        else 
        {
            Memory += 1000;
            Light5.SetActive(false);
        }

        if (BackwardsMemory == 4)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light5.SetActive(false);
        }

        if (PlanetMemory == 6)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light5.SetActive(false);
        }

        CheckMemories();
    }

    public void SixSaturn()
    {
        StopAllCoroutines();
        Memory6.SetActive(false);

        if (Memory == 5)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
            Light6.SetActive(false);
        }

        if (BackwardsMemory == 3)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light6.SetActive(false);
        }

        if (PlanetMemory == 1)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light6.SetActive(false);
        }

        CheckMemories();
    }

    public void SevenUranus()
    {
        StopAllCoroutines();
        Memory7.SetActive(false);

        if (Memory == 6)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
            Light7.SetActive(false);
        }

        if (BackwardsMemory == 2)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light7.SetActive(false);
        }

        if (PlanetMemory == 3)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light7.SetActive(false);
        }

        CheckMemories();
    }

    public void EightNeptune()
    {
        StopAllCoroutines();
        Memory8.SetActive(false);

        if (Memory == 7)
        {
            Memory++;
        }

        else
        {
            Memory += 1000;
            Light8.SetActive(false);
        }

        if (BackwardsMemory == 1)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light8.SetActive(false);
        }

        if (PlanetMemory == 7)
        {
            PlanetMemory++;
        }

        else
        {
            PlanetMemory += 1000;
            Light8.SetActive(false);
        }

       

            CheckMemories();
    }

    public void NinePluto()
    {
        StopAllCoroutines();
        Memory9.SetActive(false);

        if (Memory == 8)
        {
            Memory++;
        }

        else 
        {
            Memory += 1000;
            Light9.SetActive(false);
        }

        if (BackwardsMemory == 0)
        {
            BackwardsMemory++;
        }

        else
        {
            BackwardsMemory += 1000;
            Light9.SetActive(false);
        }

       

        CheckMemories();
    }
}
