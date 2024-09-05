using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] PlatformControl platform;

    private void Awake()
    {
        if (platform == null) { platform = FindAnyObjectByType<PlatformControl>(); }
    }


}
