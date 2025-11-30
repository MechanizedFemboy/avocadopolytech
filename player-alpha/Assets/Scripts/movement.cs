using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 25f;
    private Rigidbody2D rb;
    public float n = 25f;
    public BoxCollider2D groundcheck;
    public LayerMask groundmask;
    public bool isgrounded;
    PC pc = new PC();
    private Camera cam;
    public Vector2 BoxSize;
    public float dist;

    bool checkground()
    {
        if(Physics2D.BoxCast(transform.position, BoxSize, 0, -transform.up, dist, groundmask))
        {
            isgrounded = true;
            return isgrounded;
        }
        else
        {
            isgrounded = false;
            return isgrounded;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position - transform.up * dist, BoxSize);
    }

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    
    

    private Vector2 mostream;
    void Update()
    {
        mostream.x = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity = new Vector2(mostream.x, rb.velocity.y);

        if (Input.GetButton("Jump"))
        {
            if (checkground()) { rb.AddForce(Vector2.up * n); }
        }


        /*if (Input.GetMouseButtonDown(0)) // при нажатии левой кнопки мыши

        if (Input.GetMouseButtonDown(0))
 827cbe9c68ef5bfc1367b3661448beadcdfaac82
        {

            Vector2 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log(mp);

            if (pc.ClicktedHZ(mp))
            {
                Instantiate(pc.screen);
            }
        }*/

        // if (Input.GetMouseButtonDown(0)) // пїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅ
        // {
        //     Vector2 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //     Debug.Log(mousePos);
        /*3758d021cc1ada4108d23d5c3fb2ad9811ebbbe2*/
        //     //Vector2 mp = cam.ScreenToWorldPoint(Input.mousePosition);


        //     //if (pc.ClicktedHZ(mp))
        //     //{

        //     //}
        //     // пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ пїЅ пїЅпїЅпїЅпїЅпїЅпїЅпїЅпїЅ

        // }



        //ne pishi kommentarii kirillitsey, git stiraet ikh kogda pushaet


            if (pc.ClicktedHZ(mp))
            {
                Instantiate(pc.screen);
            }
 827cbe9c68ef5bfc1367b3661448beadcdfaac82
    }
}
}
