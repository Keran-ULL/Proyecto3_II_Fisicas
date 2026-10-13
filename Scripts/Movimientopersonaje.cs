using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movimientopersonaje : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;
    private Vector3 direccion;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        direccion = new Vector3(h, 0.0f, v).normalized;
    }

    void FixedUpdate()
    {
        Vector3 velocidad = direccion * speed;
        velocidad.y = rb.linearVelocity.y;
        rb.linearVelocity = velocidad;
    }
}
