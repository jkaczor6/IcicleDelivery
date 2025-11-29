using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 30.0f;
    [SerializeField] float moveSpeed = 1.0f;

    [SerializeField] TMP_Text boostText;
    
    void Start()
    {
        boostText.gameObject.SetActive(false);
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Boost"))
        {
            moveSpeed = 10.0f;
            boostText.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        boostText.gameObject.SetActive(false);
        moveSpeed = 5.0f;
    }
}
