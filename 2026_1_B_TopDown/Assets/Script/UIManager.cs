using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
  
    public void GameStartButtonAction()
    {
        SceneManager.LoadScene("stage");
    }
}
