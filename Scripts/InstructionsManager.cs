
using UnityEngine;

public class InstructionsManager : MonoBehaviour
{
    public GameObject instructionsPanel;
    public GameObject player;
    public GameObject spawner;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        instructionsPanel.SetActive(false);
        player.SetActive(true);
        spawner.SetActive(true);

        Time.timeScale = 1f;
    }
}
