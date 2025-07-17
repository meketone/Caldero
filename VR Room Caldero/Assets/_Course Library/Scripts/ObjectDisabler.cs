using UnityEngine;

public class ObjectDisabler : MonoBehaviour
{
    private ColorChanger colorChanger;

    private void Start()
    {
        // Busca el componente ColorChanger en Caldo
        colorChanger = GetComponent<ColorChanger>();

        if (colorChanger == null)
        {
            Debug.LogWarning("No se encontró el componente ColorChanger en Caldo.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pocion") || other.CompareTag("Libro") || other.CompareTag("Objeto"))
        {
            Debug.Log("Caldo colisionó con: " + other.gameObject.name);

            other.gameObject.SetActive(false); // El objeto desaparece

            if (colorChanger != null)
            {
                colorChanger.ChangeColorByTag(other.tag); // Caldo cambia de color
            }
        }
    }
}
