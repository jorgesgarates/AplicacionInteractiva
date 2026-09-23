using UnityEngine;
using UnityEngine.UI;

public class AnimacionOchoFrames : MonoBehaviour
{
    public float velocidad = 5f;
    public float desfase = 0f;

    private Image imagen;
    private Vector3 escalaInicial;

    private readonly float[] escalas =
    {
        1f, 1.12f, 1.22f, 1.12f,
        1f, 0.90f, 0.82f, 0.90f
    };

    void Awake()
    {
        imagen = GetComponent<Image>();
        escalaInicial = transform.localScale;
    }

    void Update()
    {
        int frame = Mathf.FloorToInt((Time.time * velocidad + desfase) % 8f);

        transform.localScale = escalaInicial * escalas[frame];

        if (imagen != null)
        {
            float brillo = 0.55f + (frame * 0.06f);
            imagen.color = new Color(0.2f, brillo, 1f, 1f);
        }
    }
}