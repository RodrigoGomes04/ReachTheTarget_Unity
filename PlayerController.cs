using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private Vector2 movement;
    private bool isMovingHorizontally = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        if (horizontalInput != 0)
        {
            isMovingHorizontally = true;
        }
        else if (verticalInput != 0)
        {
            isMovingHorizontally = false;
        }

        if (isMovingHorizontally)
        {
            movement = new Vector2(horizontalInput, 0);
            RotatePlayer(horizontalInput, 0);
        }
        else
        {
            movement = new Vector2(0, verticalInput);
            RotatePlayer(0, verticalInput);
        }
    }

    void FixedUpdate()
    {
        transform.position +=
        (Vector3)(movement * speed * Time.fixedDeltaTime);
    }

    void RotatePlayer(float x, float y)
    {
        // If there is no input, do not rotate the player
        if (x == 0 && y == 0) return;

        // Calculate the rotation angle based on input direction
        float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        // Apply the rotation to the player
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
