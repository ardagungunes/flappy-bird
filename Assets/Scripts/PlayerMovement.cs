using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    InputAction jumpAction;
    Rigidbody2D playerRigidBody;
    [SerializeField] float jumpHeight = 2f;
    bool disableInputFlag = false;
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    
    void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if (jumpAction.IsPressed() && !disableInputFlag)
        {
            playerRigidBody.linearVelocity = new Vector2(playerRigidBody.linearVelocityX, jumpHeight);
        }


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        score += 1;
        scoreText.text = score.ToString();
        Debug.Log(score);
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        disableInputFlag = true;
        SceneManager.LoadScene("GameOverScene");
    }
}
