using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int coinCount = 0;

    public TMP_Text coinText;

    // 상점 업그레이드 데이터
    public float moveSpeedBonus = 0f;
    public int hpBonus = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateCoinUI();
    }

    // 코인 획득
    public void AddCoin(int amount)
    {
        coinCount += amount;

        Debug.Log("현재 코인 : " + coinCount);

        UpdateCoinUI();
    }

    // 코인 사용
    public void SpendCoin(int amount)
    {
        coinCount -= amount;

        if (coinCount < 0)
        {
            coinCount = 0;
        }

        UpdateCoinUI();
    }

    // UI 갱신
    public void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text =
                "Coin : " + coinCount;
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        coinText =
            GameObject.Find("CoinText")
            .GetComponent<TMPro.TMP_Text>();

        UpdateCoinUI();
    }
}