using UnityEngine;

public class EsferaHaciaObjetivo : MonoBehaviour
{
    public string etiquetaObjetivo = "Objetivo";

    public Renderer obstaculo;
    public Material materialAlcanzado;

    public float speed = 2.0f;

    private Transform objetivo;
    private float radio;
    private bool obstaculoAlcanzado = false;
    private bool objetivoAlcanzado = false;

    void Start()
    {
        GameObject cilindro = GameObject.FindWithTag(etiquetaObjetivo);
        if (cilindro == null)
        {
            Debug.LogError("No hay ningún objeto con la etiqueta '" + etiquetaObjetivo + "'");
            enabled = false;
            return;
        }
        objetivo = cilindro.transform;

        radio = GetComponent<Collider>().bounds.extents.x;
    }

    void Update()
    {
        if (objetivoAlcanzado) return;

        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, speed * Time.deltaTime);

        Collider[] contactos = Physics.OverlapSphere(transform.position, radio);

        foreach (Collider c in contactos)
        {
            if (!obstaculoAlcanzado && obstaculo != null && c.gameObject == obstaculo.gameObject)
            {
                obstaculo.material = materialAlcanzado;
                obstaculoAlcanzado = true;
                Debug.Log("La esfera ha alcanzado el obstáculo " + c.name);
            }
            if (c.transform == objetivo)
            {
                objetivoAlcanzado = true;
                Debug.Log("La esfera ha alcanzado el objetivo " + c.name);
            }
        }
    }
}
