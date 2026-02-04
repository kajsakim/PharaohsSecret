using UnityEngine;
using UnityEngine.Events;
public class InteractionSystem : MonoBehaviour
{
    public Interactable CurrentInteractable;

    public HaikuInteractable Haiku1;

    public IntroHaikuInteractable IntroHaiku1;

    public SecondHaikuInteractable SecondHaiku;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && CurrentInteractable != null)
        {
            CurrentInteractable.OnInteract.Invoke();
        }

        if (Input.GetKeyDown("c") && Haiku1 != null)
        {
            Haiku1.OnInteract.Invoke();
        }

        if (IntroHaiku1 != null && Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            IntroHaiku1.OnInteract.Invoke();
        }

        if (SecondHaiku != null && Input.GetKeyDown(KeyCode.LeftAlt))
        {
            SecondHaiku.OnInteract.Invoke();
        }

    }
}
