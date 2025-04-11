using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    // movement
    public float moveSpeed = 5f;

    void moveBasedOnKeyboard()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    // shot
    public float distanceInFront = 0f;
    public float speed = 5f;

    void shotIfPlayerWants()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPosition = transform.position + transform.forward * distanceInFront;
            
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = spawnPosition;
            cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            cube.AddComponent<BulletMovementManager>();
            cube.name = "Bullet";
        }
    }

    //main
    void Start()
    {

    }

    void Update()
    {
        moveBasedOnKeyboard();
        shotIfPlayerWants();
    }
}
