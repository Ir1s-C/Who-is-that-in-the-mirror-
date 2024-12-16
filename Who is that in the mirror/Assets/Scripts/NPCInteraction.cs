using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPCInteraction : MonoBehaviour
{
    public GameObject quizUI;  
    public Text questionText; 
    public Button[] answerButtons;  
    public string[] questions;  
    public string[][] answers;  
    private int currentQuestion = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))  
        {
            quizUI.SetActive(true);  
            ShowQuestion();  
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))  
        {
            quizUI.SetActive(false);  
        }
    }

    void ShowQuestion()
    {
        questionText.text = questions[currentQuestion];  
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = answers[currentQuestion][i]; 
            answerButtons[i].onClick.RemoveAllListeners(); 
            answerButtons[i].onClick.AddListener(() => CheckAnswer(i)); 
        }
    }

    void CheckAnswer(int buttonIndex)
    {
        if (buttonIndex == 0)
        {
            currentQuestion++;
            if (currentQuestion >= questions.Length)
            {
                EndQuiz();  
            }
            else
            {
                ShowQuestion(); 
            }
        }
        else
        {
            Debug.Log("Resposta errada");
            currentQuestion = 0;  
            ShowQuestion(); 
        }
    }

    void EndQuiz()
    {
        quizUI.SetActive(false);
        SceneManager.LoadScene("Continua");
    }
}
