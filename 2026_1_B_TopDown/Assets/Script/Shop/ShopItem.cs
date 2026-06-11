using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public int cost = 5;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            Buy();
        }
    }

    void Buy()
    {
        if (GameManager.Instance.coinCount < cost)
        {
            Debug.Log("코인 부족");
            return;
        }

        GameManager.Instance.coinCount -= cost;

        Debug.Log("속도 업그레이드 구매");
    }
}