using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class ActivarAnimacionAjustes : MonoBehaviour, IPointerClickHandler
{
    private Animator animador;

    void Awake()
    {
        animador = GetComponent<Animator>();
        animador.enabled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ReproducirAnimacion());
    }

    private IEnumerator ReproducirAnimacion()
    {
        animador.enabled = true;
        animador.Play("AnimacionAjustes", 0, 0f);

        yield return new WaitForSeconds(0.55f);

        animador.enabled = false;
    }
}