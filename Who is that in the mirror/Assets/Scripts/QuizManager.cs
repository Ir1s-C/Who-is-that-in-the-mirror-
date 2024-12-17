using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public GameObject quizUI;
    public Text questionText;
    public Button[] answerButtons;
    public Text feedbackText;

    private int correctAnswers = 0;
    private int currentQuestionIndex = 0;

    // Aqui você pode declarar suas perguntas
    public Question[] questions;

    void Start()
    {
        ShowQuestion();
    }

    void ShowQuestion()
    {
        Question currentQuestion = questions[currentQuestionIndex];
        questionText.text = currentQuestion.question;
        for (int i = 0; i < currentQuestion.answers.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = currentQuestion.answers[i];
            answerButtons[i].onClick.RemoveAllListeners();
            int index = i;
            answerButtons[i].onClick.AddListener(() => AnswerQuestion(index));
        }
    }

    void AnswerQuestion(int answerIndex)
    {
        if (questions[currentQuestionIndex].correctAnswerIndex == answerIndex)
        {
            correctAnswers++;
            feedbackText.text = "Resposta Correta!";
        }
        else
        {
            feedbackText.text = "Resposta Errada!";
        }

        currentQuestionIndex++;
        if (currentQuestionIndex < questions.Length)
        {
            ShowQuestion();
        }
        else
        {
            EndQuiz();
        }
    }

    void EndQuiz()
    {
        quizUI.SetActive(false);
        if (correctAnswers == questions.Length)
        {
            SceneManager.LoadScene("Continua");
        }
        else
        {
            Debug.Log("Você falhou no quiz!");
        }
    }
}

[System.Serializable]
public class Question
{
    public string question;
    public string[] answers;
    public int correctAnswerIndex;
}
