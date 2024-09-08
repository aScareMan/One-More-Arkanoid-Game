using UnityEngine;

public class Puncher : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    ControlValues conVal;
    Vector2[] directions;
    private void Awake()
    {
        directions = new Vector2[] { new Vector2(-1, 1), new Vector2(1, 1) };
        conVal = FindAnyObjectByType<ControlValues>();
    }
    public void PunchDatBall()
    {
        rb.AddForce(directions[Random.Range(0, 2)] * conVal.basicBallSpeed);
    }
    public void PunchDatBall2()
    {
        rb.AddForce(directions[Random.Range(0, 2)] * conVal.basicBallSpeed * conVal.multiplyBallSpeed);
    }
}
