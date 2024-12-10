using UnityEngine;
using UnityEngine.Video;

public class Menu : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public GameObject menuOpcoes, rawImage;
    private Animator animatorRawImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rawImage.SetActive(false);
        animatorRawImage = rawImage.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!VideoPlayer.isPlaying && Input.anyKeyDown)
        {
            rawImage.SetActive(true);
            VideoPlayer.Play();            
            animatorRawImage.SetTrigger("FadeIn");
            menuOpcoes.SetActive(true);
        }
    }
}
