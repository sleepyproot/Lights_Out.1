using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100; // Salud inicial del jugador

    // M�todo para recibir da�o
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // M�todo para manejar la muerte del jugador
    void Die()
    {
        // Aqu� puedes poner l�gica de lo que pasa cuando el jugador muere, como reiniciar la escena o mostrar una animaci�n de muerte
        Debug.Log("Jugador muerto");

        // Ejemplo: Destruir al jugador cuando muere
        Destroy(gameObject);
    }
}
