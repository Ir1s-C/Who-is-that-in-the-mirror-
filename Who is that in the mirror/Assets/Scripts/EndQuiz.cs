using UnityEngine.SceneManagement;

void EndQuiz()
{
    quizUI.SetActive(false);
    if (correctAnswers == questions.Length)
    {
        SceneManager.LoadScene("Continua");
    }
}
