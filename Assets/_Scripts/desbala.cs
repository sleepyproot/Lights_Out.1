using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 25;  // El daño que causará la bala

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si la bala colisiona con un enemigo
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Obtiene el script "Enemy" del objeto que ha sido tocado
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                // Si el enemigo tiene el script "Enemy", le aplicamos daño
                enemy.TakeDamage(damage);
            }

            // Destruir la bala después de hacer daño
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            // Obtener el componente Health del jugador
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                // Aplicar daño al jugador
                playerHealth.TakeDamage(damage);
            }

            // Destruir el proyectil después de la colisión
            Destroy(gameObject);
        }
        else
        {
            // Si no es un enemigo, solo destruimos la bala
            Destroy(gameObject);
        }
    }
}
