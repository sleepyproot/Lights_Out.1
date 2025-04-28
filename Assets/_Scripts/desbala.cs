using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 25;  // El da�o que causar� la bala

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si la bala colisiona con un enemigo
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Obtiene el script "Enemy" del objeto que ha sido tocado
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                // Si el enemigo tiene el script "Enemy", le aplicamos da�o
                enemy.TakeDamage(damage);
            }

            // Destruir la bala despu�s de hacer da�o
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            // Obtener el componente Health del jugador
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                // Aplicar da�o al jugador
                playerHealth.TakeDamage(damage);
            }

            // Destruir el proyectil despu�s de la colisi�n
            Destroy(gameObject);
        }
        else
        {
            // Si no es un enemigo, solo destruimos la bala
            Destroy(gameObject);
        }
    }
}
