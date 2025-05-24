using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    InputAction jumpAction;
    Rigidbody2D playerRigidBody;
    [SerializeField] float jumpHeight = 2f;
    
    void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if (jumpAction.IsPressed()) {
            playerRigidBody.linearVelocity = new Vector2(playerRigidBody.linearVelocityX, jumpHeight);
        }

    }
}
