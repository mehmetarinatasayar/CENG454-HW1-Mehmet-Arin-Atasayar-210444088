using UnityEngine;

public class FlightController : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 60f;

    void Update()
    {
        float pitch = Input.GetAxis("Vertical");
        float yaw = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right * pitch * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * yaw * rotationSpeed * Time.deltaTime);
    }
}