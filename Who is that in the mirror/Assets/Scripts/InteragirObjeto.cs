using UnityEngine;
using UnityEngine.UI;

public class InteragirObjeto : MonoBehaviour
{
    public Sprite imagemDoObjeto;  
    public string descricao;
    private static GameObject detalhesCanvas;  
    private static Image imagemDetalhada;      
    private static Text descricaoTexto;        

    private void Start()
    {
        if (detalhesCanvas == null)
        {
            detalhesCanvas = GameObject.Find("DetalhesCanvas");
            imagemDetalhada = detalhesCanvas.transform.Find("ImagemDetalhada").GetComponent<Image>();
            descricaoTexto = detalhesCanvas.transform.Find("DescricaoDetalhada").GetComponent<Text>();
        }
    }

    private void OnMouseDown()
    {
        // Atualiza o Canvas com os detalhes do objeto
        detalhesCanvas.SetActive(true);
        imagemDetalhada.sprite = imagemDoObjeto;
        descricaoTexto.text = descricao;
    }
}
