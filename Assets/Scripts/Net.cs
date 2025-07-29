using UnityEngine;

public class Net : MonoBehaviour
{

    public CatchingMinigame minigameLogic;
    
    private GameObject targetBug;

    public void SetTargetBug(GameObject targetBug)
    {
        this.targetBug = targetBug;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8 && targetBug.name == other.gameObject.name)
        {
            Destroy(targetBug);
            minigameLogic.StopMinigame();
        }
    }
}
