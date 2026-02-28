using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public NPCDialog dialogData;
    public GameObject dialogPanel;
    public TMP_Text dialogText, nameText;

    private int dialogueIndex;
    private bool isTyping;
    public bool isDialogActive;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
