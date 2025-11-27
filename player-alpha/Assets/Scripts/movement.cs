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

    bool checkground()
    {
        
        isgrounded = Physics2D.OverlapAreaAll(groundcheck.bounds.min, groundcheck.bounds.max, groundmask).Length > 0;
        return isgrounded;
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
        if (Input.GetMouseButtonDown(0)) // ��� ������� ����� ������ ����
        {

            Vector2 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log(mp);

            if (pc.ClicktedHZ(mp))
            {
                Instantiate(pc.screen);
            }
    }
}
}
