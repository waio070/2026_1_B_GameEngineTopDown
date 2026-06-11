using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorObject : MonoBehaviour
{
    public string NextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("문 통과");

            SceneManager.LoadScene(NextSceneName);
        }
    }
}