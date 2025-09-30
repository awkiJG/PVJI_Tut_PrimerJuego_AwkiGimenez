using UnityEngine;

public class AcelerateMoveCommand : ICommand
{
    private PlayerMovement playerMovement;
    private float input;

    public AcelerateMoveCommand(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }
    
    public void Execute()
    {
        playerMovement.setMovementStrategy(new AcelerateMovement());
        playerMovement.MovePlayer(input);
    }
}
