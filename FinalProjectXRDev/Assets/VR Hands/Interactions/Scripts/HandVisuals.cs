using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandVisuals : MonoBehaviour

{
    [SerializeField]
    private Animator handAnim;

    [SerializeField]
    private string gripButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_Grip"))
        {

            handAnim.SetBool("Gripped", true);

        }

        if (Input.GetButtonUp(gripButton))
        {

            handAnim.SetBool("Gripped", false);

        }
    }
}