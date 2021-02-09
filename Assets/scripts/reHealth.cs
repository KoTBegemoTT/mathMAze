using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reHealth : MonoBehaviour
{
    void Awake()
    {
        var l = FindObjectOfType<LivesBar>();
        l.Refresh();
    }
}
