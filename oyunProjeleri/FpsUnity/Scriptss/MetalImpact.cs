using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalImpact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {

        yield return new WaitForSeconds(3);

        Destroy(gameObject);


        
    }
}
