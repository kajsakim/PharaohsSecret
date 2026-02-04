using UnityEngine;
using UnityEngine.Events;

public class IntroHaikuInteractable : MonoBehaviour
{
    public UnityEvent OnInteract;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<InteractionSystem>().IntroHaiku1 = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<InteractionSystem>().IntroHaiku1 = null;
        }
    }
}
