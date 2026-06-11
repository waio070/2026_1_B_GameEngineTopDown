using UnityEngine;

public class ShopUIManager : MonoBehaviour
{
    public GameObject shopPanel;

    public int speedCost = 5;
    public int hpCost = 10;

    public void BuySpeed()
    {
        if (GameManager.Instance.coinCount < speedCost)
        {
            Debug.Log("코인 부족");
            return;
        }

        GameManager.Instance.SpendCoin(speedCost);

        GameManager.Instance.moveSpeedBonus += 1f;

        Debug.Log("속도 업그레이드");
    }

    public void BuyHP()
    {
        if (GameManager.Instance.coinCount < hpCost)
        {
            Debug.Log("코인 부족");
            return;
        }

        GameManager.Instance.SpendCoin(hpCost);

        GameManager.Instance.hpBonus += 1;

        Debug.Log("체력 업그레이드");
    }

    public void CloseShop()
    {
        shopPanel.SetActive(false);

        Time.timeScale = 1f;
    }
}