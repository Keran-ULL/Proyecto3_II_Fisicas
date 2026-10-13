using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class LanzarConFuerza : MonoBehaviour
{
    public Vector3 direccion = new Vector3(0.0f, 0.5f, 1.0f);

    public float fuerza = 3.0f;

    private Rigidbody rb;
    private bool lanzar = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            lanzar = true;
        }
    }

    void FixedUpdate()
    {
        if (lanzar)
        {
            rb.AddForce(direccion.normalized * fuerza, ForceMode.Impulse);
            lanzar = false;
        }
    }
}
