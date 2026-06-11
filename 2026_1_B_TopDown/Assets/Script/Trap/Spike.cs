using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌 : " + collision.name);

        if (collision.CompareTag("Player"))
        {
            PlayerHP hp =
                collision.GetComponent<PlayerHP>();

            if (hp != null)
            {
                hp.TakeDamage(1);
            }
        }
    }
}