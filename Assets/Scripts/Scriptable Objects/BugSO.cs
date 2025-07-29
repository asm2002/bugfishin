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
    [SerializeField] private bool canJump;
    [SerializeField] private bool canFly;

    public string GetName()
    {
        return bugName;
    }

    public string GetFlavour()
    {
        return bugFlavour;
    }

    public float GetValue()
    {
        return bugValue;
    }

    public float GetMinSize()
    {
        return minBugSize;
    }

    public float GetMaxSize()
    {
        return maxBugSize;
    }

    public float GetMinWeight()
    {
        return minBugWeight;
    }

    public float GetMaxWeight()
    {
        return maxBugWeight;
    }

    public bool GetJump()
    {
        return canJump;
    }

    public bool GetFly()
    {
        return canFly;
    }

    public GameObject GetPrefab()
    {
        return bugPrefab;
    }

}
