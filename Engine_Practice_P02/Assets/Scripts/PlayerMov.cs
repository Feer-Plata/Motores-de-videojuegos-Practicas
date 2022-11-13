using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MOVEMENT
{
	NULL,
	LEFT,
	RIGHT,
    JUMP
}
public class PlayerMov : MonoBehaviour
{
	private Rigidbody2D RB;
	public float speed;
    public float jumpHeight;
    public bool Movement = false;
	public MOVEMENT MoveState;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Movement = true;
            MoveState = MOVEMENT.LEFT;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Movement = true;
            MoveState = MOVEMENT.RIGHT;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Movement = true;
            MoveState = MOVEMENT.JUMP;
        }
        else
        {
            Movement = false;
            MoveState = MOVEMENT.NULL;
        }
    }
    private void FixedUpdate()
    {
        if (MoveState == MOVEMENT.LEFT)
        {
            RB.AddForce(new Vector2(-speed, 0), ForceMode2D.Impulse);
        }
        else if (MoveState == MOVEMENT.RIGHT)
        {
            RB.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        }
        else if (MoveState == MOVEMENT.JUMP)
        {
            RB.AddForce(transform.up * jumpHeight);
        }
    }

}
