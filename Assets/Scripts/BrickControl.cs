using UnityEngine;

public class BrickControl : MonoBehaviour
{
    [SerializeField] int brickPrice = 100;
    [SerializeField] bool hasPowerup = false;
    CurrentGameManager gameManager;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<CurrentGameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //TODO sound
        //TODO Effects
        gameManager.AddScorePoints(brickPrice);

        if (hasPowerup)
        {
            //TODO Add powerUp to list
        }

        gameManager.PopBrick();

        gameObject.SetActive(false);
    }
}
