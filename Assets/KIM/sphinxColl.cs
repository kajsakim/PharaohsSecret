using UnityEngine;

public class sphinxColl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //need a ref to NPC script for an "is talking" bool, so that if player re-enters collider we dont re-start convo. maybe that can just sit in the NPC script???
    public NPC NPC; // (get the NPC script)
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player") && !NPC.isDialogActive)  //(if player collides with trigger and dialog is not active, run start dialog in NPC script)
        {
            //start dialog function in NPC script
        }
    }
}
