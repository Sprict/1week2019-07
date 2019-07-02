using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JIJI : MonoBehaviour
{
    private readonly int lifespan_MM = 30;
    public float run_speed;
    private int state;
    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        run_speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void Move()
    {
        Vector2 move_direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        this.transform.Translate(Vector2.ClampMagnitude(move_direction, 1) * Time.deltaTime * run_speed);
    }
}
