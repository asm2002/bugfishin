using UnityEngine;

[CreateAssetMenu(fileName = "BugSO", menuName = "Scriptable Objects/BugSO")]
public class BugSO : ScriptableObject
{
    [SerializeField] private string bugName;
    [SerializeField] private string bugFlavour;
    [SerializeField] private float bugValue;
    [SerializeField] private float minBugSize;
    [SerializeField] private float maxBugSize;
    [SerializeField] private float minBugWeight;
    [SerializeField] private float maxBugWeight;
    [SerializeField] private GameObject bugPrefab;

    private string GetName()
    {
        return bugName;
    }

    private string GetFlavour()
    {
        return bugFlavour;
    }

    private float GetValue()
    {
        return bugValue;
    }

    private float GetMinSize()
    {
        return minBugSize;
    }

    private float GetMaxSize()
    {
        return maxBugSize;
    }

    private float GetMinWeight()
    {
        return minBugWeight;
    }

    private float GetMaxWeight()
    {
        return maxBugWeight;
    }

    private GameObject GetPrefab()
    {
        return bugPrefab;
    }

}
