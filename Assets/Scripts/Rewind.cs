using UnityEngine;

public class Rewind : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Camera2.SetActive(false);
            Camera1.SetActive(true);
            SpawnPoint2.SetActive(false);
            SpawnPoint1.SetActive(true);
            Destroy(Player);
        }
    }
}
