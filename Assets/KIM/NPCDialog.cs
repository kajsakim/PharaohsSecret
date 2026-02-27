using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class NPCDialog
{
    public string name;
    [TextArea(2, 10)]
    public string[] sentences;
}
