using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public static change manger;
    public int s;
    public int a;
    public bool v;
    public GameObject[] x;
  //  public string i;
    // Start is called before the first frame update
    void Start()
    {
        manger = this;
        a = c.ctrl.r;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void save(int value)
    {
        if (v)
        {
            if (s < 1)
            {
                FindObjectOfType<c>().NewTetromino();
            }
            else
            {
                add();
            }
            s++;
        }

    }
    void add ()
    {
        if (v)
        {
        Instantiate(x[Random.Range(a, a)], transform.position, Quaternion.identity);
        a = c.ctrl.r;
            v = false;
        }
    }
}
