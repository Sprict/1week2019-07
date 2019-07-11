using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePanel : MonoBehaviour
{
    bool rotStart = false;
    [SerializeField]
    float speed = 3.0f;
    float rotAngle = 360f;
    float variation;
    float rot;

    private void Start()
    {
        variation = rotAngle / speed;
    }

    private void Update()
    {
        if (rotStart)
        {
            this.transform.Rotate(0, variation * Time.deltaTime, 0);
            rot += variation * Time.deltaTime;
            if(rot >= rotAngle)
            {
                rotStart = false;
                this.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }

    public void OnBtn()
    {
        rot = 0f;
        this.transform.localRotation = Quaternion.Euler(0, 0, 0);
        rotStart = true;
    }
}
