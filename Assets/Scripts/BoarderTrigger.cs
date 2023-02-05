using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarderTrigger : MonoBehaviour
{

    public SpriteRenderer top;
    public SpriteRenderer bottom;
    public SpriteRenderer right;
    public SpriteRenderer left;

    private void Start()
    {
        top.enabled = false;
        bottom.enabled = false;
        right.enabled = false;
        left.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Main Ship")
        {
            top.enabled = true;
            bottom.enabled = true;
            right.enabled = true;
            left.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Main Ship")
        {
            top.enabled = false;
            bottom.enabled = false;
            right.enabled = false;
            left.enabled = false;
        }
    }

}
