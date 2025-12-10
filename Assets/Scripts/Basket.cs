using UnityEngine;
using TMPro;

public class Basket : MonoBehaviour
{
    public bool gameOver = false;
    public int score = 0;
    public TMP_Text scoreText;
    void Update()
    {
        if (!gameOver) 
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float mouseX = mousePosition.x;
            mouseX = Mathf.Clamp(mouseX, -7.5f, 7.5f);
            transform.position = new Vector3(mouseX, transform.position.y, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!gameOver)
        {
            score += 1;
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);   
        }
    }
}
