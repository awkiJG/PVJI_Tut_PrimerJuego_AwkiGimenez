using UnityEngine;

public class AcelerateMovement : IMovementStrategy
{
    private float currentSpeed = 0f;
    private float acceleration = 2f;

    public void Move(Transform transform, float speed)
    {
        currentSpeed += Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
        currentSpeed = Mathf.Clamp(currentSpeed, -speed, speed);
        transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
    }
}
