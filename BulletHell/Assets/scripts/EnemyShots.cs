using UnityEngine;

public class EnemyShots : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 2f;
    private float fireCooldown;

    void Start()
    {
        fireCooldown = Random.Range(0f, fireRate); // para que no disparen todos al mismo tiempo
    }

    
    void Update()
    {
        fireCooldown -= Time.deltaTime;

        if (fireCooldown <= 0f)
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.Euler(0, 0, 180f)); // hacia abajo
            fireCooldown = fireRate;
        }
    }
}