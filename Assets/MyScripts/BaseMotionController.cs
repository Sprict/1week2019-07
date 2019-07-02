using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMotionController : MonoBehaviour
{
    private Animator m_Anim;
    private Rigidbody2D m_Rigidbody2D;

    [SerializeField]
    private float move_speed = 7.0f;

    private void Awake()
    {
        m_Anim = GetComponent<Animator>();
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    public void Move(float h_move, float v_move)
    {
        // 移動方向
        Vector2 direction = new Vector2(h_move, v_move).normalized;
        transform.Translate(direction * move_speed * Time.deltaTime);
        m_Anim.SetFloat("Horizontal", h_move);
        m_Anim.SetFloat("Vertical", v_move);
    }
}
