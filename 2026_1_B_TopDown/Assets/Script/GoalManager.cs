using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public int goalCount;

    private int currentCount;

    public GameObject doorObject;

    private void Start()
    {
        doorObject.SetActive(false);
    }

    public void AddBox()
    {
        currentCount++;

        if (currentCount >= goalCount)
        {
            doorObject.SetActive(true);

            Debug.Log("Door Open!");
        }
    }

    public void RemoveBox()
    {
        currentCount--;
    }
}