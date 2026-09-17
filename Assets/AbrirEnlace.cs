using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    public void AbrirURL(string direccion)
    {
        Application.OpenURL(direccion);
    }
}