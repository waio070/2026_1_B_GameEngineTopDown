using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorObject : MonoBehaviour
{
    public string NextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(NextSceneName);
        }
    }
}