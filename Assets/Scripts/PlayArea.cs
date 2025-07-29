using System;
using UnityEngine;

public class PlayArea : MonoBehaviour
{

    public CatchingMinigame minigameLogic;

    private void OnTriggerExit(Collider other)
    {

        Debug.Log("exited");

        if (minigameLogic != null)
        {
            minigameLogic.StopMinigame();
        }

        else
        {
            throw new ArgumentNullException("No minigameLogic set.");
        }
    }
}
