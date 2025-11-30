using UnityEngine;

public class Gear : MonoBehaviour
{
    bool move = false;
    Vector2 mp;
    Vector2 startP;

    public GameObject Idial;
    public GameObject G1;
    public GameObject G3;
    private Gon Gonatel;
    private Gonimaya Gonimaya;
    bool set = false;
    public float r;
    
    public float vertimsa;
    public StanokController stanokController;
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
        Gonatel = G1.GetComponent<Gon>();
        Gonimaya = G3.GetComponent<Gonimaya>();

    }
    private void OnMouseUp()
    {
       
        move = false;
        if (Mathf.Abs(this.gameObject.transform.position.x - Idial.gameObject.transform.position.x) <= r && Mathf.Abs(this.gameObject.transform.position.x - Idial.gameObject.transform.position.x) <= r)
        {
            if (Gonatel.power)
            {
                Deth();}
        
            }
            else {
                set = true;
                this.gameObject.transform.position = Idial.gameObject.transform.position;
            }
            
        }
    
    // Update is called once per frame
    void Update()
    {
        if (set && Gonatel.power)
        {
            vertimsa = Gonatel.vertimsa * -1;
        }
        if (vertimsa != 0)
        {
            transform.Rotate(0, 0, vertimsa * Time.deltaTime);
        }
        if (move)
        {
            mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            this.gameObject.transform.position = new Vector2(mp.x - startP.x, mp.y - startP.y) ;
        }
    }
    public void Deth()
    {

    }
}
