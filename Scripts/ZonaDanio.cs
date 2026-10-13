using UnityEngine;

public class ZonaDanio : MonoBehaviour
{
    public float danioPorEntrada = 10.0f;
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        DanioPersonaje personaje = other.GetComponent<DanioPersonaje>();
        if (personaje != null)
        {
            personaje.danio += danioPorEntrada;
            Debug.Log(other.name + " ha recibido " + danioPorEntrada + " de daño. Daño total: " + personaje.danio);
        }
    }
}
