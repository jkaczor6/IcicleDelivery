using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.3f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !hasPackage)
        {
            Destroy(collision.gameObject, destroyDelay);
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
        }
        else if(collision.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject, destroyDelay);
        }
    }
}
