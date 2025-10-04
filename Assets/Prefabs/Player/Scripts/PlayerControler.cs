using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private ICommand command;
    private bool useAccelerate = false;
    private float horizontalInput;

    void Start()
    {
        playerMovement = gameObject.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Cambia la estrategia solo una vez por pulsación de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            useAccelerate = !useAccelerate;
        }

        // Actualiza el comando cada frame según la estrategia activa
        if (useAccelerate)
        {
            command = new AcelerateMoveCommand(playerMovement, horizontalInput);
        }
        else
        {
            command = new MoveCommand(playerMovement, horizontalInput);
        }

        command.Execute();
    }
}
