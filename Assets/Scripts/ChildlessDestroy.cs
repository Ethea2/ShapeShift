using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildlessDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
