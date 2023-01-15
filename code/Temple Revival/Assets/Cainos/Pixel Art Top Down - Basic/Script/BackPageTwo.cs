using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPageTwo : MonoBehaviour
{
    public GameObject testNow;
    public GameObject testNext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Change()
    {
        testNow.SetActive(false);
        testNext.SetActive(true);
    }
}
