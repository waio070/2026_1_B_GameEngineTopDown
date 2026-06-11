using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour
{
    public float moveSpeed = 5f;

    public StageData currentStageData;

    private Rigidbody2D rigid;

    private Vector2 moveInput;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveInput.x =
            Input.GetAxisRaw("Horizontal");

        moveInput.y =
            Input.GetAxisRaw("Vertical");

        moveInput =
            moveInput.normalized;

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name
            );
        }
    }

    private void FixedUpdate()
    {
        float bonus = 0f;

        if (GameManager.Instance != null)
        {
            bonus = GameManager.Instance.moveSpeedBonus;
        }

        rigid.linearVelocity =
            moveInput * (moveSpeed + bonus);
    }
}