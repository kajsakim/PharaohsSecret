using UnityEngine;
using UnityEngine.SceneManagement;


public class loadLevel : MonoBehaviour
{
    public GameObject levelTrigger;
    public NPC NPC;
    public GameObject enterPopup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D(Collider2D collision)
    {
        enterPopup.SetActive(true);
        if (NPC.isDialogDone && Input.GetKeyUp(KeyCode.E))
        {
            SceneManager.LoadSceneAsync(3);//this aint working, dunno why yet.
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        enterPopup.SetActive(false);
    }
    void Start()
    {
        enterPopup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
