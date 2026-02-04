using UnityEngine;
using UnityEngine.Events;

public class SecondHaikuInteractable : MonoBehaviour
{
    public UnityEvent OnInteract;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<InteractionSystem>().SecondHaiku = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<InteractionSystem>().SecondHaiku = null;
        }
    }
}
