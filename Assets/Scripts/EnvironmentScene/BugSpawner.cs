using UnityEngine;

public class BugSpawner : MonoBehaviour
{
    [SerializeField] private BugSO bugData;
    [SerializeField] private Transform[] waypoints;

    private void Start()
    {
        SpawnBug();
    }
    public void SpawnBug()
    {
        GameObject bugGO = Instantiate(bugData.GetPrefab(), transform.position, Quaternion.identity);

        BugInstance bugInstance = bugGO.GetComponent<BugInstance>();

        bugInstance.waypoints = waypoints;

        bugInstance.InitializeBug(bugData);

        // Apply runtime scale (on the physics root if animations override scale)
        //bugGO.transform.localScale *= bugInstance.size;

        Debug.Log($"{bugData.name} spawned: Size {bugInstance.size}, Weight {bugInstance.weight}, Value {bugInstance.value}");
    }
}
