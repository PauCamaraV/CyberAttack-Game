using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacController : MonoBehaviour
{
    public float speed = 5f;
    private Animator anim;
 
    // Use this for initialization
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
 
    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        var move = new Vector3(horizontal, vertical,0);
        transform.position += move * speed * Time.deltaTime;
        Vector2 direction = new Vector2(horizontal, vertical);
        anim.SetFloat("DirX", direction.x);
        anim.SetFloat("DirY", direction.y);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "virus")
        {
            Destroy(col.gameObject);
            ScriptScore.numvir--;
        }
    }
}