using System.Collections;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public NPCDialog dialogData;
    public GameObject dialogPanel;
    public TMP_Text dialogText, nameText;
    [Header("door to level")]
    public GameObject door;
    public AudioSource doorAudio;
    public AudioClip doorSound;
    private int dialogIndex;
    private bool isTyping;
    public bool isDialogActive;
    public bool isDialogDone;

    private void Start()
    {
        door.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isDialogDone && !isDialogActive)  //(if player collides with trigger and dialog is not done, run start dialog in NPC script)
        {
            startDialog();
        }
        //if (isDialogActive)
        //{ nextLine(); }
        
    }
        
    public void startDialog()
    {
    isDialogActive = true;
    isDialogDone = false; //check if dialog is finished so it doesnt trigger again on collision?
    dialogIndex = 0;

    nameText.SetText(dialogData.NPCname);
    dialogPanel.SetActive(true);

    //type line
    StartCoroutine(TypeLine());

    }

    void nextLine()
    {
        if (isTyping)
        {
            StopAllCoroutines();
            dialogText.SetText(dialogData.sentences[dialogIndex]);
            isTyping = false;
        }
        else if (++dialogIndex < dialogData.sentences.Length)
        {
            //if another line, type next line
            StartCoroutine(TypeLine());
        }
        else
        {
            endDialog();
        }
    }

    public void endDialog()
    {
        StopAllCoroutines();
        isDialogActive = false;
        isDialogDone = true;
        dialogText.SetText("");
        dialogPanel.SetActive(false);
        door.SetActive(false);
        doorAudio.PlayOneShot(doorSound);
        

    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        dialogText.SetText("");

        foreach(char letter in dialogData.sentences[dialogIndex])
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(dialogData.typingSpeed);
        }
        
        isTyping = false;

        if(dialogData.autoProgressLines.Length > dialogIndex && dialogData.autoProgressLines[dialogIndex])
        {
            yield return new WaitForSeconds(dialogData.autoProgressDelay);
            nextLine();
        }

    }
}
