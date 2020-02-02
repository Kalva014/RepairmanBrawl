using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private Vector2 targetPos;
    public float dashRange;
    public float speed;
    private Vector2 direction;
    private Animator animator;
    public enum facing { up, down, left, right, upright, upleft, downleft, downright };
    public facing lookDirection = facing.down;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        TakeInput();
        Move();
    }

    private void Move()
    {
        direction = direction.normalized;
        transform.Translate(direction * speed * Time.deltaTime);

        if (direction.x != 0 || direction.y != 0)
        {
            if (animator != null)
            {
                SetAnimatorMovement(direction);
            }

        }
        else
        {
            if (animator != null)
            {
                animator.SetLayerWeight(1, 0);
            }
        }
    }

    private void TakeInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
            lookDirection = facing.up;
        }

         if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
            lookDirection = facing.left;

        }


         if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
            lookDirection = facing.down;

        }

         if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
            lookDirection = facing.right;

        }
         if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            direction = new Vector2(-1.0f, 1.0f);
            lookDirection = facing.upleft;

        }
         if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            direction = new Vector2(1.0f, 1.0f);
            lookDirection = facing.upright;
        }
         if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            direction = new Vector2(-1.0f, -1.0f);
            lookDirection = facing.downleft;

        }
         if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            direction = new Vector2(1.0f, -1.0f);
            lookDirection = facing.downright;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 currPos = transform.position;
            targetPos = Vector2.zero;
            if (lookDirection == facing.up)
            {
                targetPos.y += 1;
            }
            if (lookDirection == facing.down)
            {
                targetPos.y -= 1;
            }
            if (lookDirection == facing.right)
            {
                targetPos.x += 1;
            }
            if (lookDirection == facing.left)
            {
                targetPos.x -= 1;
            }
            transform.Translate(targetPos * dashRange);
        }
    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
        //print(animator.GetFloat("xDir"));
        //print(animator.GetFloat("yDir"));

    }
}
