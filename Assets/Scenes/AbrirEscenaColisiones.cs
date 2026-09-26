using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class AbrirEscenaColisiones : MonoBehaviour
{
    public void AbrirEscena()
    {
        SceneManager.LoadScene("EscenaColisiones");
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AbrirEscena();
        }
    }
}