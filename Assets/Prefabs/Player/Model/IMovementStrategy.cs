using UnityEngine;

public interface IMovementStrategy
{
    
    public void Move(Transform transform, Player playe, float direction);

}
