using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewNPCDialog", menuName = "NPC Dialog")]

public class NPCDialog : ScriptableObject
{
    public string NPCname;
    [TextArea(2, 10)]
    public string[] sentences;
    public bool[] autoProgressLines;
    public float typingSpeed = 0.05f;
    public float autoProgressDelay = 1.5f;
}
