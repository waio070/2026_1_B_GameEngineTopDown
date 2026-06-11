using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    private int currentHP;

    public TMP_Text hpText;

    private void Start()
    {
        currentHP = GameManager.Instance.currentHP;

        UpdateHPUI();
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        GameManager.Instance.currentHP = currentHP;

        UpdateHPUI();

        if (currentHP <= 0)
        {
            Die();
        }
    }

    void UpdateHPUI()
    {
        if (hpText != null)
        {
            hpText.text =
                "HP : " +
                currentHP +
                "/" +
                GameManager.Instance.maxHP;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject hpObj =
            GameObject.Find("HPText");

        if (hpObj != null)
        {
            hpText =
                hpObj.GetComponent<TMPro.TMP_Text>();

            UpdateHPUI();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }

    public void IncreaseMaxHP(int amount)
    {
        currentHP += amount;

        GameManager.Instance.currentHP = currentHP;

        UpdateHPUI();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}