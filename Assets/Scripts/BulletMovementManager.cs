using UnityEngine;

public class BulletMovementManager : MonoBehaviour
{
    // collision
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == Constants.ENEMY)
        {
            Destroy(gameObject);

            EnemyMovementController enemy = collision.gameObject.GetComponent<EnemyMovementController>();
            enemy.reduceLife();
        }
    }

    // move
    public float speed = 2f;

    void moveForward()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
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
