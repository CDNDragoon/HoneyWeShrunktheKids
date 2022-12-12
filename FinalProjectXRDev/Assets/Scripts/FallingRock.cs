using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour
{
    [SerializeField]
    private GameObject rock;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(fallingRock());
    }

    IEnumerator fallingRock()
    {
        yield return new WaitForSeconds(2);
        rock.GetComponent<Rigidbody>().useGravity = true;
        rock.GetComponent<Rigidbody>().isKinematic = false;

        Destroy(rock, 4);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
