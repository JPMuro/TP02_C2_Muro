using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 thirdPersonOffset = new Vector3(0, 3, -6);
    public Vector3 firstPersonOffset = new Vector3(0, 1, 0);

    public float mouseSensitivity = 3f;

    private bool firstPerson = false;
    private float rotationX = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            firstPerson = !firstPerson;
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationX += mouseX;
        target.rotation = Quaternion.Euler(0, rotationX, 0);

        if (firstPerson)
        {
            transform.position = target.position + target.TransformDirection(firstPersonOffset);
        }
        else
        {
            transform.position = target.position + target.TransformDirection(thirdPersonOffset);
        }

        transform.LookAt(target);
    }
}