using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlValues : MonoBehaviour
{
    [SerializeField] int basicPlatformSpeed = 4;
    public int basicBallSpeed = 5;
    [Space]
    [SerializeField] int maxBallSpeed = 2;


    public int GetPlatformSpeed { get { return basicPlatformSpeed; } }

}
