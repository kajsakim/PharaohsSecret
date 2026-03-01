using UnityEngine;
using UnityEngine.SceneManagement;

public class backToEntry : MonoBehaviour
{
    //go back to entry room level if player walks into collider
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadSceneAsync("entry-room");
    }
}