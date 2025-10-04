using UnityEngine;

public class Player 
{
    private float velocity;
    private float acceleration;
    private float aceleratedSpeed = 0f;

    public Player(float velocity, float acceleration)
    {
        this.velocity = velocity;
        this.acceleration = acceleration;
    }

    public float Velocity { get => velocity; set => velocity = value; }

    public float Acceleration { get => acceleration; set => acceleration = value; }

    public float AceleratedSpeed { get => aceleratedSpeed; set => aceleratedSpeed = value; }
}
