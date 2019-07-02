using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharactorController : MonoBehaviour
{
    private BaseMotionController m_Character;

    private void Awake()
    {
        m_Character = GetComponent<BaseMotionController>();
    }
    // Update is called once per frame
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 移動
        m_Character.Move(h, v);
    }
}
