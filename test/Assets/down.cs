using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour
{
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   //     y = c.ctrl.e/10;
        
     //   if (c.ctrl.e > 0)
      //  {
      //      transform.position += new Vector3(0, -0.5f, 0);
         //   c.ctrl.getDown(1);
      //  }
    }
    public void Clear()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ff")
        {
            transform.position += new Vector3(0, -1, 0);

        }

    }
}
