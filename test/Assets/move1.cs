using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject use;
    public float t = 0.4f;
    public bool z;
    public bool R;
    public bool L;
    public float drop;
    public float falltime = 1;
    public static int height = 20;
    public static int width = 6;
    public static Transform[,] grid = new Transform[width, height];
    public Vector3 p;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - drop > falltime)
        {

            if (z)
            {
                a.GetComponent<Collider2D>().enabled = false;
                b.GetComponent<Collider2D>().enabled = false;
                c.GetComponent<Collider2D>().enabled = false;
                d.GetComponent<Collider2D>().enabled = false;
                transform.position += new Vector3(0, -1, 0);
                drop = Time.time;
            }
            if (!z)
            {
                t = t - Time.deltaTime;
                if (t < 0)
                {
                    FindObjectOfType<c>().NewTetromino();
                    a.GetComponent<Collider2D>().enabled = true;
                    b.GetComponent<Collider2D>().enabled = true;
                    c.GetComponent<Collider2D>().enabled = true;
                    d.GetComponent<Collider2D>().enabled = true;
                    this.enabled = false;
                    GetComponent<area1>().enabled = false;
                    change.manger.v = true;
                    //       GetComponent<down>().enabled = true;
                }
                //  FindObjectOfType<clear>().Check();
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            falltime = falltime/2;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            falltime = 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (!R)
            {
                transform.position += new Vector3(-1, 0, 0);
                R = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            transform.position += new Vector3(-1, 0, 0);
            if (!L)
            {
                transform.position += new Vector3(1, 0, 0);
                L = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.TransformPoint(p), new Vector3(0, 0, 1), 90);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (change.manger.v)
            {
                Destroy(gameObject);

            }
            change.manger.save(1);
        }
            foreach (Transform children in transform)
        {
            int roundedX = Mathf.RoundToInt(children.transform.position.x);
            int roundedY = Mathf.RoundToInt(children.transform.position.y);

            if (roundedY < -2 || roundedY >= height)
            {
                    z = false;
            }
            if (roundedX < -4)
            {
                L = false;
            }
            if (roundedX >= width)
            {
                R = false;
            }

        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "block")
        {
            z = false;

        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "RR")
        {
            transform.position += new Vector3(-0.5f, 0, 0);

        }
        if (other.name == "LL")
        {
            transform.position += new Vector3(0.5f, 0, 0);

        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "block")
        {
            z = true;

        }

    }

}

