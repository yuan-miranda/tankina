using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public float lifetime = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * speed;
        // Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
