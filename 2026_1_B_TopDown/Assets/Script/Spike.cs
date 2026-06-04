using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌 : " + collision.name);

        if (collision.CompareTag("Player"))
        {
            Debug.Log("플레이어 사망");

            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name
            );
        }
    }
}