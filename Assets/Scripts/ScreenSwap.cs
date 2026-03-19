using TMPro;
using UnityEditor;
using UnityEngine;

public class ScreenSwap : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public MemoryPuzzle MemoryPuzzle;
    public TMP_Text ErrorCounterScore;
    public GameObject Attempts;
    public GameObject PlanetHint;
    public GameObject PlanetText;

    private void Start()
    {
        MemoryPuzzle = GameObject.FindGameObjectWithTag("MemoryPuzzle").GetComponent<MemoryPuzzle>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
            Destroy(GameObject.Find("Player1(clone)"));
            ErrorCounterScore.text = "Congratulations! Attempts: " + MemoryPuzzle.ErrorCounter.ToString();
            Attempts.SetActive(true);
            PlanetHint.SetActive(false);
            PlanetText.SetActive(false);

        }
    }

    public void StopTimers()
    {
        StopAllCoroutines();
    }
}
