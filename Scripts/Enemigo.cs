using UnityEngine;

public class Enemigo : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        string capa = LayerMask.LayerToName(collision.gameObject.layer);
        Debug.Log(gameObject.name + " ha colisionado con " + collision.gameObject.name + " (capa " + capa + ")");
    }
}
