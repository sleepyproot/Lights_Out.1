using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;       // Referencia al jugador
    public float speed = 2f;       // Velocidad de movimiento
    public float stopDistance = 1f; // Distancia mínima antes de dejar de moverse
    public float rotationSpeed = 5f; // Velocidad de rotación

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance < stopDistance)
        {
            // Movimiento del enemigo hacia el jugador
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * speed * Time.deltaTime;

            // Rotación del enemigo hacia el jugador
            Vector3 targetDirection = player.position - transform.position;
            float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

            // Rotación suave
            Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
