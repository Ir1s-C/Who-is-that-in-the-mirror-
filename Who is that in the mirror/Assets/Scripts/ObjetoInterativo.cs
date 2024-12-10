using UnityEngine;

public class ObjetoInterativo : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver()
    {
        spriteRenderer.color = Color.blue; 
    }

    void OnMouseExit()
    {
        spriteRenderer.color = Color.white;
    }

    void OnMouseDown()
    {
        Debug.Log("Objeto clicado: " + gameObject.name);
    }
}