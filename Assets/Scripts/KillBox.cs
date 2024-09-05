using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        //TODO прокинуть смэрть в контроллер, разместить на стартовой позиции
        // ТУДУ если нет хп то все, конец
        // А еще взрыв из частиц! Ну полюбому надо :)
    }
}
