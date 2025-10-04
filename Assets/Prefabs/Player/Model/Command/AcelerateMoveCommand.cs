using UnityEngine;

public class AcelerateMoveCommand : ICommand
{
    private PlayerMovement playerMovement;
    private readonly float input;

    public AcelerateMoveCommand(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
        playerMovement.setMovementStrategy(new AcelerateMovement());
    }
    
    public void Execute()
    {
        playerMovement.MovePlayer(input);
    }
}
