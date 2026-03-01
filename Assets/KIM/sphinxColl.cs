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
        if(collision.CompareTag("player") && !NPC.isDialogDone)  //(if player collides with trigger and dialog is not done, run start dialog in NPC script)
        {
            NPC.startDialog();
            /*
             I dont know if this will work the same with collisson as trigger instead of button/interact
            if (NPC.isDialogActive)
            {
                //if dialog not done but has already started, continue
                NPC.nextLine();
            }
            else
            {
                //start dialog function in NPC script
                NPC.startDialog();
            }*/
                
        }
    }
}
