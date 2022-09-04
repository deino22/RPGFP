using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public int number = 1;
    public Rigidbody2D rb;
    Vector2 movemet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movemet.x = Input.GetAxisRaw("Horizontal");
        movemet.y = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate()
    {
       rb.MovePosition(rb.position + movemet * number);
    }



}
