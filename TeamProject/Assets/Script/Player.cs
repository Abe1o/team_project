using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer m_SpriteRenderer;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (Mathf.Abs(h) > 0.2f)
        {
            anim.SetFloat("Speed",1);
        }
        else
        {
            anim.SetFloat("Speed", 0);
        }

        if (h >= 0)
        {
            m_SpriteRenderer.flipX = false;
        }
        else
        {
            m_SpriteRenderer.flipX = true;
        }

        transform.Translate(new Vector2(h * speed * Time.deltaTime, 0));
    }
}
