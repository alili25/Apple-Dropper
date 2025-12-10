using UnityEngine;

public class MissZone : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            gameManager.LoseBasket();
        }
    }
}