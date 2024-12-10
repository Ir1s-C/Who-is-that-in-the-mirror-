using UnityEngine; 
public class PlayerController : MonoBehaviour 
{ 
    public float moveSpeed = 5f; 
    public float interactionRange = 2f; 
    public LayerMask interactableLayer; 
    private Rigidbody2D rb; private Vector2 movement; 
    
    void Start() 
    { 
        rb = GetComponent<Rigidbody2D>(); 
    } 
    
    void Update() 
    { 
        float moveX = Input.GetAxisRaw("Horizontal"); 
        float moveY = Input.GetAxisRaw("Vertical"); m
        ovement = new Vector2(moveX, moveY).normalized; 
        if (Input.GetKeyDown(KeyCode.E)) { Interact(); } } void FixedUpdate() 
        { 
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 
        } 
        
        void Interact() 
        { 
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, interactionRange, interactableLayer); 
            if (hit.collider != null) 
            { 
                IInteractable interactable = hit.collider.GetComponent<IInteractable>(); 
                
                if (interactable != null) 
                { 
                    interactable.OnInteract(); 
                    } 
            } 
        } 
    } 