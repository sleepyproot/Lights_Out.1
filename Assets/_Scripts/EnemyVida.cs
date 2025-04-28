using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;  // La vida del enemigo

    // Este método es llamado para aplicar daño al enemigo
    public void TakeDamage(float damage)
    {
        health -= damage;  // Reducir la vida del enemigo por el valor del daño

        if (health <= 0)
        {
            Die();  // Llamamos al método para destruir al enemigo si la vida es menor o igual a 0
        }
    }

    // Este método maneja la muerte del enemigo (puede destruirlo o hacer cualquier otra cosa)
    void Die()
    {
        Destroy(gameObject);  // Destruye al enemigo
    }
}
