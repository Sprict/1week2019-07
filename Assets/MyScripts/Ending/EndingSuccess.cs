﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSuccess : MonoBehaviour
{
    // 勇者の能力の変数の値を呼び出す
    public int yuusyaAbilityValue;
    private int ending_flames = 0;
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

        if (yuusyaAbilityValue >= 10)
        {
            ending_flames += 1;
            TextMove();
        }
    }

    void TextMove()
    {
        if (ending_flames > start_flame && ending_flames <= start_flame + move_flame)
            this.transform.Translate(0, -move_speed, 0);
    }
}