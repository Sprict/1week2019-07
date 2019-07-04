using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingJiji : MonoBehaviour
{
    private int ending_flames;
    public int start_flame;
    public int move_flame;
    public float move_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ending_flames += 1;
        TextMove();
    }

    void TextMove()
    {
        if(ending_flames > start_flame && ending_flames <= start_flame + move_flame)
            this.transform.Translate(0, -move_speed, 0);
    }
}