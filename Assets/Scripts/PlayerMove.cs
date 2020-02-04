using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D body;

    float hori;
   

    public int runSpeed = 10;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal"); 
    }
    void FixedIpdate()
    {
        body.velocity = new Vector2(hori * runSpeed, 0 );
    }
}
