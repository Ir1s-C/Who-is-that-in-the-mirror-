using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Escada"))
        {
            SceneManager.LoadScene("Porão");
        }
    }
}
