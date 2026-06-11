using UnityEngine;

public class ShopUIManager : MonoBehaviour
{
    public GameObject shopPanel;

    public int speedCost = 5;
    public int hpCost = 10;

    private void Update()
    {
        if (shopPanel.activeSelf &&
            Input.GetKeyDown(KeyCode.Escape))
        {
            CloseShop();
        }
    }

    public void BuySpeed()
    {
        if (GameManager.Instance.coinCount < speedCost)
        {
            Debug.Log("코인 부족");
            return;
        }

        GameManager.Instance.SpendCoin(speedCost);

        GameManager.Instance.moveSpeedBonus += 1f;

        Debug.Log("이동속도 증가");
    }

    public void BuyHP()
    {
        if (GameManager.Instance.coinCount < hpCost)
        {
            Debug.Log("코인 부족");
            return;
        }

        GameManager.Instance.SpendCoin(hpCost);

        GameManager.Instance.maxHP += 1;

        PlayerHP playerHP =
            FindFirstObjectByType<PlayerHP>();

        if (playerHP != null)
        {
            playerHP.IncreaseMaxHP(1);
        }

        Debug.Log("최대 체력 증가");
    }

    public void CloseShop()
    {
        shopPanel.SetActive(false);

        Time.timeScale = 1f;
    }
}