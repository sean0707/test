using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check : MonoBehaviour
{
   // public string b;
    public static check manger;
    public int point;
    public Text text1;
    public Text text2;
    public GameObject target;
    public int ss = 30;
    // public int c;
    // Start is called before the first frame update
    void Start()
    {
        if (manger == null)
        {
            manger = this;
        }
        text2.text = ss.ToString();
    }

    // Update is called once per frame
    void Update()
    {


     //   b = a.ToString();
    }
    public void score(int value)
    {
        point += value;
        text1.text = point.ToString();
        if (point >= ss)
        {
            //  target.GetComponent<SpriteRenderer>().enabled = true;
            target.SetActive(true);
        }

    }




}
