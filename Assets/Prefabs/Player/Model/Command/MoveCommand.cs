using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerMovement playerMovement;
    private float input;

    public MoveCommand(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }
    
    public void Execute()
    {
        playerMovement.setMovementStrategy(new SmoothMovemet());
        playerMovement.MovePlayer(input);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
}
