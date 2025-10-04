using UnityEngine;

public class AcelerateMovement : IMovementStrategy
{
    public void Move(Transform transform, Player player, float direction)
    {
        player.AceleratedSpeed += direction * player.Acceleration * Time.deltaTime;
        player.AceleratedSpeed = Mathf.Clamp(player.AceleratedSpeed, -player.Velocity, player.Velocity);

        transform.Translate(player.AceleratedSpeed * Time.deltaTime, 0, 0);
    }
}
