using UnityEngine;
using Yarn.Unity;

public class TriggerStart : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    void Start()
    {
        dialogueRunner.StartDialogue("Start"); 
    }
}
