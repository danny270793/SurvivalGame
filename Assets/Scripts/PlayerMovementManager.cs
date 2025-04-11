using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    // movement
    public float moveSpeed = 5f;

    void moveBasedOnKeyboard()
    {
        float moveX = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(moveX, 0, 0);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    //main
    void Start()
    {

    }

    void Update()
    {
        moveBasedOnKeyboard();
    }
}
