using UnityEngine;

public class Net : MonoBehaviour
{

    public CatchingMinigame minigameLogic;

    public PlayerStats stats;

    private GameObject targetBug;

    public void SetTargetBug(GameObject targetBug)
    {
        this.targetBug = targetBug;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (true)
        {
            stats.AddBug(targetBug.GetComponent<BugInstance>());
            Destroy(targetBug);

            minigameLogic.StopMinigame();
        }
    }
}
