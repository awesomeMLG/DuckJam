using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    protected Vector2 axisMove;

    protected Rigidbody2D playerPhysics;

    protected bool isGrounded;

    [SerializeField] protected Transform feet;

    [SerializeField] protected float radius;
    // Start is called before the first frame update
    void Awake()
    {
        playerPhysics = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetDirection(Vector2 axisRef)
    {
        axisMove = axisRef;
    }

    protected void CheckGround()
    {
        isGrounded = Physics2D.CircleCast(feet.position, radius, Vector2.down);
    }
}
