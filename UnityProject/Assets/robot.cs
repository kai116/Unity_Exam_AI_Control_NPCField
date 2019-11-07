using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour {

    [Header("TALK")]
    public string  SAY;
    public float sayspeed = 1.3f;

    [Header("mission")]
    public bool complete;
    public float bateryfinish = 1.1f;
    public float batery = 0f;

}
