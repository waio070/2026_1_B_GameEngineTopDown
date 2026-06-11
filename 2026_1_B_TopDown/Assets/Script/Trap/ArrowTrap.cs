using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    public GameObject arrowPrefab;

    public Vector2 shootDirection;

    public float shootInterval = 2f;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= shootInterval)
        {
            Shoot();

            timer = 0f;
        }
    }

    void Shoot()
    {
        GameObject arrow =
            Instantiate(
                arrowPrefab,
                transform.position,
                Quaternion.identity
            );

        arrow.GetComponent<Arrow>()
             .Init(shootDirection);
    }
}