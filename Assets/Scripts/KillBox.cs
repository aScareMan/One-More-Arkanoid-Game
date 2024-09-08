using UnityEngine;

public class KillBox : MonoBehaviour
{
    CurrentGameManager gameManager;
    private void Awake()
    {
        gameManager = FindAnyObjectByType<CurrentGameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        gameManager.RemoveHealthPoint();
        //TODO ���������� ��� �� ��������� �������
        // ���� ���� ��� �� �� ���, �����
        // � ��� ����� �� ������! �� �������� ���� :)
    }
}
