using UnityEngine;

public class Gear : MonoBehaviour
{
    bool move = false;
    Vector2 mp;
    Vector2 startP;
    public GameObject Idial;
    bool set = false;
    public float r;
    private void OnMouseDown()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
            //startP.x = mp.x-transform.position.x;
            //startP.y = mp.y-transform.position.y;
            startP = Vector2.zero;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnMouseUp()
    {
        Debug.Log("mp");
        move = false;
        if (Mathf.Abs(this.gameObject.transform.position.x- Idial.gameObject.transform.position.x)<=r && Mathf.Abs(this.gameObject.transform.position.x - Idial.gameObject.transform.position.x) <= r)
        {
            set = true;
            this.gameObject.transform.position = Idial.gameObject.transform.position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            this.gameObject.transform.position = new Vector2(mp.x - startP.x, mp.y - startP.y) ;
        }
    }
}
