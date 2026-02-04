using System.Collections;
using UnityEngine;

public class PlatformTimer : MonoBehaviour
{
    public int Timer;
    


    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(Timer);
        gameObject.SetActive(false);
        
    }

    private void OnEnable()
    {
        StartCoroutine(Deactivate());
    }

   
    
}
