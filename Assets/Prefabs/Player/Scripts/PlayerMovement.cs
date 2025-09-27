using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forceToApply = new Vector3(0, 0, 300); // Fuerza en la dirección Z
        timeSinceLastForce = 0f;
        intervalTime = 2f; // Aplica la fuerza cada 2 segundos
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
