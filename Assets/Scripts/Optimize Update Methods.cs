using UnityEngine;

public class OptimizedExample : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating(nameof(PerformAction), 0, 0.5f); // Executes every 0.5 seconds
    }

    void PerformAction()
    {
        Debug.Log("Action executed");
    }
}
