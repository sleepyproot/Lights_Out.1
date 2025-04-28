using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;  // Prefab del proyectil
    public float shootingForce = 10f;    // Fuerza con la que se dispara el proyectil
    public Transform shootingPoint;      // El punto desde donde se dispara el proyectil (usualmente cerca del ca��n del jugador)

    void Update()
    {
        // Detectamos si el jugador ha presionado el bot�n izquierdo del rat�n
        if (Input.GetMouseButtonDown(0))
        {
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        // Creamos el proyectil en la posici�n del jugador o el punto de disparo
        GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);

        // Obtenemos la direcci�n hacia el mouse
        Vector2 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;

        // Aplicamos una fuerza al proyectil para que se dispare en la direcci�n del mouse
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = direction * shootingForce;
    }
}
