using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Profiling;

public class PerformanceLogger : MonoBehaviour
{
    void Update()
    {
        Debug.Log($"Draw Calls: {Profiler.GetTotalDrawCalls()}");
        Debug.Log($"Memory Usage: {Profiler.GetTotalAllocatedMemoryLong() / 1048576f} MB");
    }
}

