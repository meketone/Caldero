using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer objRenderer;

    private void Start()
    {
        // Busca el Renderer en el objeto o sus hijos
        objRenderer = GetComponent<Renderer>();

        if (objRenderer == null)
        {
            objRenderer = GetComponentInChildren<Renderer>();
        }

        if (objRenderer != null)
        {
            // Crea una copia del material para que sea exclusivo de Caldo
            objRenderer.material = new Material(objRenderer.material);
        }
        else
        {
            Debug.LogWarning("No se encontró un Renderer en Caldo ni en sus hijos.");
        }
    }

    public void ChangeColorByTag(string tag)
    {
        if (objRenderer == null) return;

        switch (tag)
        {
            case "Pocion":
                objRenderer.material.color = Color.red;
                break;
            case "Libro":
                objRenderer.material.color = Color.blue;
                break;
            case "Objeto":
                objRenderer.material.color = Color.green;
                break;
            default:
                objRenderer.material.color = Color.white;
                break;
        }
    }
}
