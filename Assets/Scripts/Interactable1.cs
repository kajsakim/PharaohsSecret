using UnityEngine;
using UnityEngine.Events;

public class HaikuInteractable : MonoBehaviour
{
    public UnityEvent OnInteract;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<InteractionSystem>().Haiku1 = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<InteractionSystem>().Haiku1 = null;
        }
    }

    
}
