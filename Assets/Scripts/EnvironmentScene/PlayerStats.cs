using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float money;
    private List<BugData> caughtBugs = new List<BugData>();

    public void AddBug(BugInstance bugInstance)
    {
        BugData newBug = new BugData(bugInstance);
        caughtBugs.Add(newBug);

        Debug.Log($"Caught: {newBug.baseBug.name}, Size: {newBug.size}, Weight: {newBug.weight}, Value: {newBug.value}");
    }
}
