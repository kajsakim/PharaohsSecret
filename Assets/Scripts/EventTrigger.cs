using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent Destroyed;
    public UnityEvent OnExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnEnter.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        OnExit.Invoke();
    }

    private void OnDestroy()
    {
        Destroyed.Invoke();
    }
}
