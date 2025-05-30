using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Mover en dirección "arriba" local, que respeta la rotación del objeto
        rb.linearVelocity = transform.up * speed;
    }

    void Update()
    {
        if (transform.position.y < -10f || transform.position.y > 10f)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.TakeDamage(1);
            }

            Destroy(gameObject); // destruye la bala tras hacer daño
        }
    }
}