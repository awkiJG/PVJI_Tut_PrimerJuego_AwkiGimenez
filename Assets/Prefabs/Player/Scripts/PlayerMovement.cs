using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;
    private IMovementStrategy movementStrategy;
    private Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forceToApply = new Vector3(300, 0, 0); // Fuerza en la dirección Z
        timeSinceLastForce = 0f;
        intervalTime = 2f; // Aplica la fuerza cada 2 segundos

        player = new Player(5f, 10f);
        // setMovementStrategy(new SmoothMovemet());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.AceleratedSpeed);
    }

    public void MovePlayer(float input)
    {
        movementStrategy.Move(transform, player, input);
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
