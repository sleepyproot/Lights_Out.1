using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    void Update()
    {
        // Obtener la posición del mouse en el mundo
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // Asegurarse de que la posición Z sea 0 para 2D

        // Calcular la dirección del mouse respecto al objeto
        Vector3 direction = mousePos - transform.position;

        // Calcular el ángulo en radianes y convertirlo a grados
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Aplicar la rotación (rotamos en el eje Z en 2D)
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
