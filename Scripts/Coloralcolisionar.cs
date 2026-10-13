using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Coloralcolisionar : MonoBehaviour
{
    public bool cambiarColorDelOtro = false;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " ha colisionado con " + collision.gameObject.name);
        GameObject objetivo = cambiarColorDelOtro ? collision.gameObject : gameObject;
        Renderer rend = objetivo.GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = Random.ColorHSV(0f, 1f, 0.7f, 1f, 0.8f, 1f);
        }
    }
}
