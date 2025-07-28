using UnityEngine;

public class CatchingMinigame : MonoBehaviour
{

    private bool minigameRunning = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (minigameRunning) { minigame(); }
    }

    void StartMinigame()
    {
        minigameRunning = true;
    }

    void StopMinigame()
    {
        minigameRunning = false;
    }

    void minigame()
    {

    }

}
