using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    public int answerIndex;
    public QuizManager quizManager;

    public void OnAnswerClicked()
    {
        quizManager.CheckAnswer(answerIndex);
    }
}
