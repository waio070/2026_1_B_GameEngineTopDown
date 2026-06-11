using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 5f;

    private Vector2 moveDir;

    public void Init(Vector2 dir)
    {
        moveDir = dir.normalized;
    }

    private void Update()
    {
        transform.Translate(
            moveDir * speed * Time.deltaTime
        );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHP hp =
                collision.GetComponent<PlayerHP>();

            if (hp != null)
            {
                hp.TakeDamage(1);
            }

            Destroy(gameObject);
        }

        if (collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("Box"))
        {
            Destroy(gameObject);
        }
    }
}