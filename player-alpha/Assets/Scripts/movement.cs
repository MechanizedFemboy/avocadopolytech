using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
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

    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprt = GetComponent<SpriteRenderer>();
        //когда-нибудь он будет спавниться рядом с дверьми, а не в центре комнаты, но мне ещё столько функций к сдаче проекта допиливать...
    }

    void Animate()
    {
        bool IsMoving = Input.GetAxisRaw("Horizontal") != 0;
        sprt.flipX = Input.GetAxisRaw("Horizontal") < 0;
        anim.SetBool("IsMoving", IsMoving);
    }

    private Vector2 mostream;
    void Update()
    {
        mostream.x = Input.GetAxisRaw("Horizontal") * speed;
        rb.velocity = new Vector2(mostream.x, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (checkground()) { rb.AddForce(Vector2.up * n); }
        }

        Animate();
    }

    Scene sc;
    void OnDestroy()
    {
        sc = SceneManager.GetActiveScene();
        SaveSystem.LoadSituation();
        SaveSystem.sit.LastScene = sc.name;
        SaveSystem.SaveSituation();
    }
}


