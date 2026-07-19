using UnityEngine;


public class Character : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;

    [SerializeField] CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
        
        characterController.Move(transform.TransformDirection(direction) * speed * Time.deltaTime);
    }
}
