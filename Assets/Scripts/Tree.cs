using UnityEngine;

public class TreeMovement : MonoBehaviour
{
    public float speed = 3f;
    public float leftLimit = -7f;
    public float rightLimit = 7f;
    private int direction = 1; 

    void Update()
    {
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

        if (transform.position.x > rightLimit)
            direction = -1;

        if (transform.position.x < leftLimit)
            direction = 1;
    }
}