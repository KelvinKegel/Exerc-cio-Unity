using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    float rotationSpeed = 180;

    private void Start()
    {
        Vector3 to = new Vector3(90, 0, 0);
        transform.eulerAngles = to;
    }

    // Update is called once per frame
    void Update () {

        //transform.localScale += Vector3.left * Time.deltaTime;
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }
}
