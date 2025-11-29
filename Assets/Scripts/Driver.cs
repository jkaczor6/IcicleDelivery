using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 30.0f;
    [SerializeField] float moveSpeed = 1.0f;
    
    void Start()
    {
        
    }


    void Update()
    {
        if(Keyboard.current.wKey.isPressed)
        {
            transform.Translate(0.0f, moveSpeed * Time.deltaTime, 0.0f);
        } else if(Keyboard.current.sKey.isPressed)
        {
            transform.Translate(0.0f, -moveSpeed * Time.deltaTime, 0.0f);
        }

        if(Keyboard.current.aKey.isPressed)
        {
            transform.Rotate(0, 0, steerSpeed * Time.deltaTime);
        } else if(Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(0, 0, -steerSpeed * Time.deltaTime);
        }
    }
}
