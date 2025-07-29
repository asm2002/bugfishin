using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CatchingMinigame : MonoBehaviour
{

    private bool minigameRunning = false;
    private Vector3 gamePos;

    public GameObject playArea;
    public GameObject net;
    public GameObject handVisializer;

    [Range(-5f, 0f)]
    public float playAreaYOffset = -4.75f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playArea.SetActive(false);
        net.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (minigameRunning) { minigame(); }
    }

    
    public void StartMinigame(Transform bugTransform)
    {
        if (!minigameRunning)
        {
            gamePos = bugTransform.position;

            playArea.transform.position = new Vector3(gamePos.x, gamePos.y + playAreaYOffset, gamePos.z);
            playArea.SetActive(true);

            handVisializer.SetActive(false);
            net.SetActive(true);

            minigameRunning = true;

            Debug.Log("Starting");
        }
    }

    [ContextMenu("Start Minigame")]
    public void StartMinigame()
    {
        if (!minigameRunning)
        {
            gamePos = new Vector3(887.970642f, 7.98849249f, 27.7298489f);

            playArea.transform.position = new Vector3(gamePos.x, gamePos.y + playAreaYOffset, gamePos.z);
            playArea.SetActive(true);

            handVisializer.SetActive(false);
            net.SetActive(true);

            minigameRunning = true;

            Debug.Log("Starting");
        }
    }

    [ContextMenu("Stop Minigame")]
    public void StopMinigame()
    {
        if (minigameRunning)
        {
            playArea.SetActive(false);

            handVisializer.SetActive(true);
            net.SetActive(false);

            minigameRunning = false;

            Debug.Log("Stopping");
        }
    }

    void minigame()
    {
        throw new NotImplementedException("CatchingMinigame/minigame");
    }

}
