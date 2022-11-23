using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area1 : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    public GameObject a5;
    public GameObject a6;
    F mode = F.w1;
    public enum F
    {
        w1 = 1,
        w2 = 2,
        w3 = 3,
        w4 = 4,
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mode = mode + 1;
            switch (mode)
            {
                case F.w1:
                    a1.SetActive(true);
                    a2.SetActive(false);
                    a3.SetActive(false);
                    a4.SetActive(false);
                    a5.SetActive(false);
                    a6.SetActive(false);
                    break;
                case F.w2:
                    a1.SetActive(false);
                    a2.SetActive(true);
                    a3.SetActive(false);
                    a4.SetActive(false);
                    a5.SetActive(true);
                    a6.SetActive(false);
                    break;
                case F.w3:
                    a1.SetActive(false);
                    a2.SetActive(true);
                    a3.SetActive(true);
                    a4.SetActive(true);
                    a5.SetActive(false);
                    a6.SetActive(false);
                    break;
                case F.w4:
                    a1.SetActive(false);
                    a2.SetActive(false);
                    a3.SetActive(false);
                    a4.SetActive(true);
                    a5.SetActive(false);
                    a6.SetActive(true);
                    mode = 0;
                    break;
            }
        }
    }
}
