using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100; // Salud inicial del jugador

    // Método para recibir daño
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Método para manejar la muerte del jugador
    void Die()
    {
        // Aquí puedes poner lógica de lo que pasa cuando el jugador muere, como reiniciar la escena o mostrar una animación de muerte
        Debug.Log("Jugador muerto");

        // Ejemplo: Destruir al jugador cuando muere
        Destroy(gameObject);
    }
}
