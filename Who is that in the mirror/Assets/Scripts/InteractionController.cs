using UnityEngine;

public class InteractionController : MonoBehaviour
{
    public GameObject canvas;
    private bool isNearObject = false;

    void Start()
    {
        if (canvas != null)
        {
            canvas.SetActive(false);
        }
    }

    void Update()
    {
        if (isNearObject && Input.GetKeyDown(KeyCode.E))
        {
            if (canvas != null)
            {
                canvas.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && canvas.activeSelf)
        {
            canvas.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearObject = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNearObject = false;
        }
    }
}
