using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class del : MonoBehaviour
{
    public GameObject t;
    public GameObject q;
    public int g;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
            if (other.tag == "block")
            {
                g = g + 1;

            }
    }
   // public void OnTriggerExit2D(Collider2D other)
   // {
     //   if (other.tag == "block")
    //    {
      //      g = g - 1;
     //   }

  //  }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "block")
        {
            if (g >= 10)
            {
             //   FindObjectOfType<down>().Clear();
                Instantiate(t, transform.position, Quaternion.identity);
                Instantiate(q, transform.position, Quaternion.identity);
                g = 0;
            }
        }

    }
}
