using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    [SerializeField] Slider healthBar;


    // Start is called before the first frame update
    void Start()
    {
        healthBar.value = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Hand"))
       {
            healthBar.value = healthBar.value - 0.1f;
       }
        
    }
}
