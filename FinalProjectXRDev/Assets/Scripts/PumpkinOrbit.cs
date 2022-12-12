using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PumpkinOrbit : MonoBehaviour
{
    [SerializeField]
    private Transform centre;

    [SerializeField]
    private float rotationSpeed;

    public float xSpread;
    public float ySpread;
    public float zSpread;
  


    float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Rotate();
    }
    private void Rotate()
    {
        float x = -Mathf.Cos(time) * xSpread;
        float y = -Mathf.Sin(time) * ySpread;    
        float z = Mathf.Sin(time) * zSpread;

        Vector3 pos = new Vector3(x, y, z);
        transform.position = pos + centre.position;
    }
}
