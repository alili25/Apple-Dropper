using UnityEngine;

public class Apple : MonoBehaviour
{
    float bottomY = -6f;

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(gameObject);
        }
    }
}
