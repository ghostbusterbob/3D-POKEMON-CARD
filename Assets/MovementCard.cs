using UnityEngine;

public class MovementCard : MonoBehaviour
{
    public float tiltAmount = 10f;
    public float followSpeed = 5f;

    private Quaternion startRot;

    void Start()
    {
        startRot = transform.rotation;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calculate target small rotation relative to start
        Quaternion targetRot = startRot *
                               Quaternion.Euler(mouseY * tiltAmount, -mouseX * tiltAmount, 0);

        // Smoothly move toward it
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime * followSpeed);
    }
}
