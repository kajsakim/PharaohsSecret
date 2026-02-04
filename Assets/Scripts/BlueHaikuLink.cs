using UnityEngine;

public class BlueHaikuLink : MonoBehaviour
{
    BlueSwitchHaiku BlueSwitchRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BlueSwitchRef = FindFirstObjectByType<BlueSwitchHaiku>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death()
    {
        BlueSwitchRef.IncreaseBlueHaiku();
    }
}
