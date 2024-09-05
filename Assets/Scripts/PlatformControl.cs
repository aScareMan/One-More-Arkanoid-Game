using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    ControlSchematic inputActions;
    [SerializeField] BallControl ball;
    Vector3 _v3Position;
    private void Awake()
    {
        inputActions = new ControlSchematic();
        _v3Position = transform.position;
        if (ball == null) { ball = FindAnyObjectByType<BallControl>(); }
    }

    private void FixedUpdate()
    {
        _v3Position.x = inputActions.Game.Mouse_Pos.ReadValue<float>() * 20;
        Debug.Log(_v3Position.x);
        transform.position = _v3Position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 10);
    }
}
