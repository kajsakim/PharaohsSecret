using UnityEngine;

public class ScreenSwap : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject BlueSpawn1;
    public GameObject BlueSpawn2;
    public GameObject YellowSpawn1;
    public GameObject AudioSource1;
    public GameObject AudioSource2;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            SpawnPoint1.SetActive(false);
            SpawnPoint2.SetActive(true);
            BlueSpawn1.SetActive(false);
            YellowSpawn1.SetActive(false);
            AudioSource1.SetActive(false);
            AudioSource2.SetActive(true);
            Destroy(GameObject.Find("BlueBox(Clone)"));
            Destroy(GameObject.Find("YellowBox(Clone)"));
        }
    }

    public void StopTimers()
    {
        StopAllCoroutines();
    }
}
