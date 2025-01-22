using UnityEngine;
using UnityEngine.InputSystem;

public class AJ : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            controller.Move(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            controller.Move(Vector3.back * Time.deltaTime);
        }



    }
}
