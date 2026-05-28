using UnityEngine;

public class GoalObject : MonoBehaviour
{
    public GoalManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            manager.AddBox();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            manager.RemoveBox();
        }
    }
}