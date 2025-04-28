using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    void Update()
    {
        // Obtener la posici�n del mouse en el mundo
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // Asegurarse de que la posici�n Z sea 0 para 2D

        // Calcular la direcci�n del mouse respecto al objeto
        Vector3 direction = mousePos - transform.position;

        // Calcular el �ngulo en radianes y convertirlo a grados
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Aplicar la rotaci�n (rotamos en el eje Z en 2D)
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
