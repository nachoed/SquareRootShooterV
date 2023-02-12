using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfOverTime : MonoBehaviour
{

    public float time;

    void Start()
    {
        StartCoroutine(DestorySelf(time));
    }

    IEnumerator DestorySelf(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
    
}
