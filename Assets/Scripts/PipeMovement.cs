using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    
    Rigidbody2D rb;
    [SerializeField] float pipeVelocity = -1f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(pipeVelocity, 0);

    }

    
    void Update()
    {
        

    }

    


}
