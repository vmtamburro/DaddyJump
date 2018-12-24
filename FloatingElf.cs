using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingElf : MonoBehaviour
{
    public float horizontalSpeed = 5f;//moveSpeed
    public float frequency = 20f;
    //public float verticalSpeed;
    public float amplitude = 0.5f; //magnitude
    public Vector3 pos, localScale;
    bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        CheckWhereToFace();

        if(facingRight)
            MoveRight();
        else
            MoveLeft();
        
        //tempPosition.x += horizontalSpeed;
        //tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
    }

    void CheckWhereToFace()
    {
        if (pos.x < -7f)
            facingRight = true;
        else if (pos.x > 7f)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;
    }

    void MoveRight()
    {
        pos += transform.right * Time.deltaTime * horizontalSpeed;
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * amplitude;

    }

    void MoveLeft()
    {
        pos -= transform.right * Time.deltaTime * horizontalSpeed;
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * amplitude;
    }
}
