using UnityEngine;

public class CameraFollwPlayer : MonoBehaviour
{
    private Vector3 offSet;
    private PlayerMovement playerMovement;
    void Start()
    {
        offSet = new Vector3(-4, 2, 0);
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void LateUpdate()
    {
        gameObject.transform.position = playerMovement.transform.position + offSet;
    }


}
