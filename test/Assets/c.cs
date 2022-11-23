using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c: MonoBehaviour
{
    public static c ctrl;
    public float e;
    public float t;
    public int r;
    public GameObject[] Tetrominoes;
    //    public float t = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        ctrl = this;
        NewTetromino();
    }

    public void NewTetromino()
    {
        r = Random.Range(0, Tetrominoes.Length);
        Instantiate(Tetrominoes[Random.Range(r,r)], transform.position, Quaternion.identity);
    }
    public void get(int value)
    {
        e += value;
        t = 0.5f;
        t = t - Time.deltaTime;
        {
            if (t < 0)
            {
                t = 0.5f;
                e = 0;
            }
        }
    }
    void Update()
    {
    }

}
