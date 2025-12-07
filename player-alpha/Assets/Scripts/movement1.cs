using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;


public class movement1 : MonoBehaviour
{
    
    public float speed = 25f;
    private Rigidbody2D rb;
    public float n = 25f;
    public LayerMask groundmask;
    public bool isgrounded;
    private Camera cam;
    public Vector2 BoxSize;
    public float dist;
    private Animator anim;
    private SpriteRenderer sprt;
    public bool Tma;
    public float timeLeft;
    public bool isRunning ;
    public GameObject Sh;


    void Start()
    {
        //Sh = GetComponent<GameObject>();
        Sh = GetComponentInChildren<GameObject>();
   
        isRunning = true;
        cam = Camera.main;
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprt = GetComponent<SpriteRenderer>();

        timeLeft = Random.Range(120, 240);
    }
    bool checkground()
    {
        if (Physics2D.BoxCast(transform.position, BoxSize, 0, -transform.up, dist, groundmask))
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

    void Animate()
    {
        bool IsMoving = Input.GetAxisRaw("Horizontal") != 0;
        sprt.flipX = Input.GetAxisRaw("Horizontal") < 0;
      
        anim.SetBool("IsMoving", IsMoving);
    }

    private Vector2 mostream;
    void Update()
    {
        /*
        if (isRunning && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else if (timeLeft <= 0)
        {
            Debug.Log("Время вышло!");
            Tma = true;
            isRunning = false;
        }
        if (Tma)
        {
            Sh.transform.localScale = new Vector2(1,1);
        }
        else
        {
            Sh.transform.localScale = Vector2.zero;
        }
        */
        mostream.x = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity = new Vector2(mostream.x, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (checkground()) { rb.AddForce(Vector2.up * n); }
        }

        Animate();
    }
   
}