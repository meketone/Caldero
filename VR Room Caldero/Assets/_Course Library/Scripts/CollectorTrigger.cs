using UnityEngine;

public class CollectorTrigger : MonoBehaviour
{
    private Renderer objRenderer;

    private void Start()
    {
        // Obtener el Renderer del objeto para cambiar su color
        objRenderer = GetComponent<Renderer>();
        if (objRenderer == null)
        {
            Debug.LogWarning("El objeto no tiene un Renderer asignado.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pocion") || other.CompareTag("Libro") || other.CompareTag("Objeto"))
        {
            Debug.Log("Recolectado: " + other.gameObject.name);
            other.gameObject.SetActive(false);

            // Cambiar color según el tag
            if (objRenderer != null)
            {
                switch (other.tag)
                {
                    case "Pocion":
                        objRenderer.material.color = Color.red;     // Rojo para Pociones
                        break;
                    case "Libro":
                        objRenderer.material.color = Color.blue;    // Azul para Libros
                        break;
                    case "Objeto":
                        objRenderer.material.color = Color.green;   // Verde para Objetos
                        break;
                }
            }
        }
    }
}
