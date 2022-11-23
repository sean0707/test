using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour
{
    public float a;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "block")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            a = transform.position.y;
            check.manger.score(10);
            c.ctrl.get(1);
        }
    }

}
