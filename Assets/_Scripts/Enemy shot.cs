using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public float detectionRange = 5f; // Rango de detección
    public float shootingCooldown = 2f; // Tiempo de espera entre disparos
    public GameObject projectilePrefab; // Prefab del proyectil
    public Transform shootingPoint; // Punto donde el enemigo disparará el proyectil
    public float projectileSpeed = 5f; // Velocidad del proyectil

    private Transform player; // Referencia al jugador
    private float lastShotTime = 0f; // Última vez que el enemigo disparó

    void Start()
    {
        // Buscar al jugador en la escena
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            // Calcular la distancia entre el enemigo y el jugador
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            // Comprobar si el jugador está dentro del rango de detección
            if (distanceToPlayer <= detectionRange)
            {
                // Si el tiempo de espera entre disparos ha pasado, disparar
                if (Time.time - lastShotTime >= shootingCooldown)
                {
                    Shoot();
                    lastShotTime = Time.time; // Actualizar el tiempo del último disparo
                }
            }
        }
    }

    void Shoot()
    {
        // Crear el proyectil en el punto de disparo
        GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);

        // Obtener el componente Rigidbody2D del proyectil
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Calcular la dirección hacia el jugador
            Vector2 direction = (player.position - transform.position).normalized;

            // Aplicar una velocidad en esa dirección
            rb.velocity = direction * projectileSpeed;
        }
    }
}
