using UnityEngine;

public class ControlValues : MonoBehaviour
{
    [SerializeField] int basicPlatformSpeed = 4;
    public int basicBallSpeed = 5;
    public int multiplyBallSpeed = 2;
    int bricksAmmount = 21;

    public int GetPlatformSpeed { get { return basicPlatformSpeed; } }
    public int GetBricksAmmount { get { return bricksAmmount; } }
}
