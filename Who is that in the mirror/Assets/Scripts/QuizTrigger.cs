using UnityEngine;

public class QuizTrigger : MonoBehaviour
{
    public QuizManager quizManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            quizManager.StartQuiz();
        }
    }
}
