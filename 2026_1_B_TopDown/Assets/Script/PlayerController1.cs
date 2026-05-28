using UnityEngine;

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

    private void Start()
    {
        transform.position =
            currentStageData.playerStartPosition;
    }

    private void Update()
    {
        moveInput.x =
            Input.GetAxisRaw("Horizontal");

        moveInput.y =
            Input.GetAxisRaw("Vertical");

        moveInput =
            moveInput.normalized;
    }

    private void FixedUpdate()
    {
        rigid.linearVelocity =
            moveInput * moveSpeed;
    }
}