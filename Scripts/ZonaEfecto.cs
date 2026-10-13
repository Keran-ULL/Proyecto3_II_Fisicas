using UnityEngine;

public class ZonaEfecto : MonoBehaviour
{
    [Header("Color del personaje")]
    public Color colorDentro = Color.blue;

    [Header("Luz")]
    public Light luz;                       
    public Color colorLuzDentro = new Color(1.0f, 0.3f, 0.3f);
    public float intensidadDentro = 0.4f;

    private Color colorOriginalPersonaje;
    private Color colorOriginalLuz;
    private float intensidadOriginalLuz;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log(other.name + " ha entrado en " + gameObject.name);

        Renderer rend = other.GetComponent<Renderer>();
        if (rend != null)
        {
            colorOriginalPersonaje = rend.material.color;
            rend.material.color = colorDentro;
        }

        if (luz != null)
        {
            colorOriginalLuz = luz.color;
            intensidadOriginalLuz = luz.intensity;
            luz.color = colorLuzDentro;
            luz.intensity = intensidadDentro;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log(other.name + " ha salido de " + gameObject.name);

        Renderer rend = other.GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = colorOriginalPersonaje;
        }

        if (luz != null)
        {
            luz.color = colorOriginalLuz;
            luz.intensity = intensidadOriginalLuz;
        }
    }
}
