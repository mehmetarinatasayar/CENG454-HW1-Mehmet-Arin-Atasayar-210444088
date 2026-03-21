using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    public float speed = 15f;
    public float turnSpeed = 60f;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(vertical * turnSpeed * Time.deltaTime,
                         horizontal * turnSpeed * Time.deltaTime,
                         0);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
