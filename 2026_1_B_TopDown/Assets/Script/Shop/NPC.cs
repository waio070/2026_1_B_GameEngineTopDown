using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject shopPanel;

    private bool canOpenShop;

    private void Update()
    {
        if (canOpenShop &&
            Input.GetKeyDown(KeyCode.E))
        {
            shopPanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canOpenShop = true;

            Debug.Log("E키를 눌러 상점 열기");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canOpenShop = false;
        }
    }
}