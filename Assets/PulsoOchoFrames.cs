using UnityEngine;

public class PulsoOchoFrames : MonoBehaviour
{
    public float velocidad = 5f;
    public float desfase = 0f;

    private Vector3 escalaInicial;

    private float[] escalas =
    {
        1f, 1.10f, 1.20f, 1.10f,
        1f, 0.90f, 0.80f, 0.90f
    };

    void Start()
    {
        escalaInicial = transform.localScale;
    }

    void Update()
    {
        int frame = Mathf.FloorToInt((Time.time * velocidad + desfase) % 8);
        transform.localScale = escalaInicial * escalas[frame];
    }
}