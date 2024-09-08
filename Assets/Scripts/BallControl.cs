using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] PlatformControl platform;

    private void Awake()
    {
        if (platform == null) { platform = FindAnyObjectByType<PlatformControl>(); }
    }


}
