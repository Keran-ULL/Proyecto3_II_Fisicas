using UnityEngine;

public class Recolectable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        string capa = LayerMask.LayerToName(other.gameObject.layer);
        Debug.Log(other.name + " (capa " + capa + ") ha recogido " + gameObject.name);

        Destroy(gameObject);
    }
}
