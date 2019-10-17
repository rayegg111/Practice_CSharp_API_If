using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicken : MonoBehaviour {

    Animator myAnimator;

	// Use this for initialization
	void Start ()
    {
            Debug.Log("123");
        myAnimator = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //吃飯
        if (Input.GetKeyDown(KeyCode.E))
        {
            myAnimator.SetTrigger("吃飯觸發器");
            Debug.Log("123");
        }
        //跑步
        if (Input.GetKey(KeyCode.R))
        {
            myAnimator.SetBool("跑步開關", true);
        }
        else
        {
            myAnimator.SetBool("跑步開關", false);
        }
	}
}
