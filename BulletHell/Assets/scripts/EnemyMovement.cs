using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float destroyY = -6f; // posición fuera de cámara por debajo

    void Start()
    {
        // Rota el objeto 180 grados alrededor del eje Z
        transform.Rotate(0f, 0f, 180f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.y < destroyY)
        {
            Destroy(gameObject);
        }
    }
}