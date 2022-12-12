using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    [SerializeField]
    private float _spinSpeedX;
    [SerializeField]
    private float _spinSpeedY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_spinSpeedX * Time.deltaTime, _spinSpeedY * Time.deltaTime, 0);
    }
}
