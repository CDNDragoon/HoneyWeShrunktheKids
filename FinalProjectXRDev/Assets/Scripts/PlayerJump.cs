using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private float jumpStrength;

    Rigidbody playerBody;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
        Jump();
    }
    public void Jump()
    {
        playerBody.AddForce(transform.up * jumpStrength);
    }
}

    // Update is called once per frame
    //void Update()
    //{
    //    Jump();
    //}

//    private void FixedUpdate()
//    {
//        Jump();
//    }
//}
