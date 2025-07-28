using UnityEngine;

public class BugUIRotation : MonoBehaviour
{

    [Range(0.01f, 1f)]
    public float rotationSpeed = 0.5f;

    void Update()
    {
        transform.Rotate(transform.position.normalized, rotationSpeed);
    }
}
