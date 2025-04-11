using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public float moveSpeed = 10f;

    void moveForward()
    {
        Vector3 move = new Vector3(0, 0, -1);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    // main
    void Start()
    {
        
    }

    void Update()
    {
        moveForward();
    }
}
