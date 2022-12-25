using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    [SerializeField] private GameObject tp;
    [SerializeField] private int tpTimer = 5;
   
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(tpTimer));
    }

    void Update()
    {

    }

    IEnumerator ExecuteAfterTime(float waittime)
    {
        yield return new WaitForSeconds(waittime);   
        Destroy(tp); 
    }

}
