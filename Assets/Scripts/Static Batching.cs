using System.Collections;
using System.Collections.Generic;
using UnityEngine;
void EnableStaticBatching()
{
    GameObject[] staticObjects = GameObject.FindGameObjectsWithTag("StaticObject");
    foreach (GameObject obj in staticObjects)
    {
        obj.isStatic = true; // Mark objects as static
    }
}
