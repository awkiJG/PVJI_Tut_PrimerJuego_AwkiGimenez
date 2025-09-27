using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;

    private Vector3 speed;
    private IMovementStrategy movementStrategy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forceToApply = new Vector3(300, 0, 0); // Fuerza en la dirección Z
        timeSinceLastForce = 0f;
        intervalTime = 2f; // Aplica la fuerza cada 2 segundos

        speed = new Vector3(5f, 0, 0); // Velocidad en la dirección X
        // setMovementStrategy(new SmoothMovemet());
        setMovementStrategy(new AcelerateMovement());
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        movementStrategy.Move(transform, speed.x);
    }

    private void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;

        if (timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply);
            timeSinceLastForce = 0f;
        }
    }

    public void setMovementStrategy(IMovementStrategy movementStrategy)
    {
        this.movementStrategy = movementStrategy;
    }
}
