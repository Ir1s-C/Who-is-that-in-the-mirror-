using UnityEngine;

public class EspelhoTrigger : MonoBehaviour
{
    public GameObject npc;
    public GameObject quizUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            npc.SetActive(true); 
            quizUI.SetActive(true); 
        }
    }
}
