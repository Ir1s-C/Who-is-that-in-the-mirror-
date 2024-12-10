using UnityEngine;

public class MouseInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Clicou em: " + hit.collider.name);
                if (hit.collider.CompareTag("Interativo"))
                {
                    Debug.Log("Interagiu com um objeto interativo!");
                }
            }
        }
    }
}