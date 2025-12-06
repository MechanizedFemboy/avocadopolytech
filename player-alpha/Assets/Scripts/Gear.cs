using UnityEngine;

public class Gear : MonoBehaviour
{
    bool move;
    Vector2 mp;
    Vector2 startP;

    public GameObject Idial;
    public GameObject G1;
    public GameObject G3;
    private Gon Gonatel;
    private Gonimaya Gonimaya;
    bool set = false;
    public float r;
    public GameObject Pole;
    public float vertimsa;
    public StanokController stanokController;
    private Vector2 pp;
    public float granica;
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
        if (!set) { 
            move = false;
            if (Mathf.Abs(this.gameObject.transform.position.x - Idial.gameObject.transform.position.x) <= r && Mathf.Abs(this.gameObject.transform.position.x - Idial.gameObject.transform.position.x) <= r)
            {
                set = true;

                if (Gonatel.power)
                {
                    Deth();
                }
                else
                {
                    this.gameObject.transform.position = Idial.gameObject.transform.position;

                }
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Gonatel.power && set)
        {
            vertimsa = -1 * Gonatel.vertimsa;
            Gonimaya.Well(-vertimsa);
        }
        if (vertimsa != 0)
        {
            transform.Rotate(0, 0, vertimsa * Time.deltaTime);
        }
        if (move)
        {
            mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            this.gameObject.transform.position = new Vector2(mp.x - startP.x, mp.y - startP.y);
            if (Mathf.Abs(mp.x - pp.x) < granica && Mathf.Abs(mp.y - pp.y) < granica)
            {
                this.gameObject.transform.position = new Vector2(mp.x - startP.x, mp.y - startP.y);
            }
        }
    }
    public void Deth()
    {
        Debug.Log("Umer"); // ялепрэ б мхыере
    }
}