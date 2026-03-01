using UnityEngine;
using UnityEngine.SceneManagement;


public class loadLevel : MonoBehaviour
{
    public BoxCollider2D levelTrigger;
    public NPC NPC;
    public GameObject enterPopup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerStay2D(Collider2D collision)
    {
        enterPopup.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            if (NPC.isDialogDone)
            {
                SceneManager.LoadSceneAsync("memoryPuzzle_kk");
            }
            //if (Input.GetKey(KeyCode.E))
            //{
                
                //SceneManager.LoadSceneAsync("memoryPuzzle_kk");//this aint working, dunno why yet.
            //}
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
