using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    // life
    public int life = 100;

    void changeColorBasedOnLife()
    {
        if(life > 50 && life < 80)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if(life <= 50)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    // movement
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
        changeColorBasedOnLife();
    }
}
