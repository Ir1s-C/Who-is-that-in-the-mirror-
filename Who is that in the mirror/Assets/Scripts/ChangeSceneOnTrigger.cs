using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnTrigger : MonoBehaviour
{
    public string sceneToLoad = "Por�o";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
