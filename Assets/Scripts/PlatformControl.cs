using System.Collections;
using System.Collections.Generic;
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
        }
        Debug.Log(_v3Position.x);
        transform.position = _v3Position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 10);
    }

    public void ToggleMouseControl(bool value)
    {
        isMouseControlled = value;
    }

}
