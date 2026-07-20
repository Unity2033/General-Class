using UnityEngine;

public class Mouse : MonoBehaviour
{
    private float axis = 0f;

    [SerializeField] private Transform character;

    [SerializeField] private float sensitivity = 200f;

    private void Start()
    {
        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivity * Time.deltaTime;

        axis -= mouseY;

        axis = Mathf.Clamp(axis, -55f, 55f);

        transform.localRotation = Quaternion.Euler(axis, 0f, 0f);
        
        character.Rotate(Vector3.up * mouseX);
    }
}
