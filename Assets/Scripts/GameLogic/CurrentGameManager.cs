using UnityEngine;

[RequireComponent(typeof(ControlValues))]
public class CurrentGameManager : MonoBehaviour
{
    ControlValues mainValues;
    [SerializeField] int score = 0;
    [SerializeField] int healthPoints = 1;
    [SerializeField] TMPro.TMP_Text scoreText;
    Puncher puncher;
    BallControl ball;
    Vector3 ballPos;
    int bricksPopped = 0;

    private void Awake()
    {
        mainValues = GetComponent<ControlValues>();
        puncher = FindAnyObjectByType<Puncher>();
        ball = FindAnyObjectByType<BallControl>();
        ballPos = ball.transform.position;

        scoreText.text = score.ToString();
    }
    private void Start()
    {
        puncher.PunchDatBall();
    }


    public void AddScorePoints(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }

    public void RemoveHealthPoint()
    {
        healthPoints--;
        if (healthPoints < 0) { UnityEngine.SceneManagement.SceneManager.LoadScene(0); }
        RestartBall();
    }
    public void AddHealthPoint()
    {
        healthPoints++;
    }
    public void RestartBall()
    {
        ball.gameObject.SetActive(true);
        ball.transform.position = ballPos;
        puncher.PunchDatBall();
        puncher.PunchDatBall2();
    }
    public void PopBrick()
    {
        bricksPopped += 1;
        if (bricksPopped >= mainValues.GetBricksAmmount)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
