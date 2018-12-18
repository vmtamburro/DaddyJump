using UnityEngine;

public class PlatformScript : MonoBehaviour {

    public float jumpForce = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            //check if object is coming from above or below.
            if (rb != null)
            {
                //set speed directly, instead of having it be relative to fall
                //can't modify a component of the vector without modifying the whole vector
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }

        }
    }
}
