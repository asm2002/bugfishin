[System.Serializable]
public class BugData
{
    public BugSO baseBug;
    public float size;
    public float weight;
    public float value;

    public BugData(BugInstance instance)
    {
        baseBug = instance.baseBug;
        size = instance.size;
        weight = instance.weight;
        value = instance.value;
    }
}
