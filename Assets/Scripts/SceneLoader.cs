using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] private KeyCode ReloadMainMenu;

    [Header("Settings")]
    [SerializeField] private string ThisSceneName;
    [SerializeField] private string OtherScene;
    [SerializeField] private float LoadDelay;

    [Header("Debug")]
    [SerializeField] private bool CanReloadScene = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(ReloadMainMenu) && CanReloadScene)
        {
            LoadScene(ThisSceneName);
        }

    }

    private void LoadScene(string SceneName) => SceneManager.LoadScene(SceneName);

    public void ToggleCanLoadSceneWithInput(bool CanLoadScene) => CanReloadScene = CanLoadScene;

    public void LoadOtherSceneDelayed() => StartCoroutine(LoadOtherSceneDelayedSeq());

    private IEnumerator LoadOtherSceneDelayedSeq()
    {
        if (LoadDelay <= 0)
            LoadDelay = 0.001f;

        yield return new WaitForSeconds(LoadDelay);
        SceneManager.LoadScene(OtherScene);
    }
}
