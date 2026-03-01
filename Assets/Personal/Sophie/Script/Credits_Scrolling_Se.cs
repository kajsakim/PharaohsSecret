using UnityEngine.SceneManagement;
using UnityEngine;

public class Credits_Scrolling_Se : MonoBehaviour
{
    public float Scroll_Speed = 62.0f; // the speed that the text moves at
    public float Scroll_Timer = 42.0f; // the duration of the timer that will send the player back to the main menu.

    private RectTransform Rect_Transform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rect_Transform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll_Timer -= Time.deltaTime;
        Rect_Transform.anchoredPosition += new Vector2(0, Scroll_Speed * Time.deltaTime);
        
        if (Scroll_Timer <= 0)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
