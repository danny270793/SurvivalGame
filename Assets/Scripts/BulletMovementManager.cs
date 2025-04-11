using UnityEngine;

public class BulletMovementManager : MonoBehaviour
{
    // move
    public float speed = 2f;

    void moveForward()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void checkWithWhichWillCollide()
    {
        RaycastHit hit;

        Vector3 direction = transform.forward;
        float timeAhead = 1f;

        float distance = speed * timeAhead;

        if (Physics.Raycast(transform.position, direction, out hit, distance))
        {
            if(hit.collider.name == "Enemy")
            {
                Destroy(gameObject);
            }
        }
    }

    // main
    void Start()
    {
        
    }

    void Update()
    {
        moveForward();
        checkWithWhichWillCollide();
    }
}
