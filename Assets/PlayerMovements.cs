using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(0, 200, 500);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
