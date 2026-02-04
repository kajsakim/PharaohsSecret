using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject PrefabToSpawn;
    public Quaternion SpawnRotation;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(PrefabToSpawn, transform.position, SpawnRotation);
    }

    // Update is called once per frame
    void Update()
    {
        RespawnBox();
    }

    void RespawnBox()
    {   //Checks if Object is in the scene
        bool Found = GameObject.Find("BlueBox(Clone)");
        //String name is the name of the Object in the scene (not the prefab)


        if (Found == false)
        {
            Instantiate(PrefabToSpawn, transform.position, SpawnRotation);
        }
        //If Object is not found in the scene Instantiate Object
    }
}
