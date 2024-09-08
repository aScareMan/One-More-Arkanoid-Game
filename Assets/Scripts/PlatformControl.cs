using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    InputMainHandler inputActions;
    [SerializeField] BallControl ball;
    [SerializeField] ControlValues values;
    Vector3 _v3Position;
    [SerializeField] bool isMouseControlled = true;
    private void Awake()
    {
        values = FindAnyObjectByType<ControlValues>();
        _v3Position = transform.position;
        if (ball == null) { ball = FindAnyObjectByType<BallControl>(); }
    }

    private void Start()
    {
        inputActions = InputMainHandler.Instance;   //SafeFromRace
    }

    private void FixedUpdate()
    {
        if (isMouseControlled)
        {
            _v3Position.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        }
        else
        {
            _v3Position.x += inputActions.MoveRangeOnX * values.GetPlatformSpeed;
            if (Mathf.Abs(_v3Position.x) > 9.0f)
            { _v3Position.x = _v3Position.x > 0 ? 9.0f : -9.0f; }
        }
        transform.position = _v3Position;
    }

    public void ToggleMouseControl(bool value)
    {
        isMouseControlled = value;
    }

}
