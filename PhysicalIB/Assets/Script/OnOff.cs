using UnityEngine;
using System.Collections;

public class OnOff : MonoBehaviour {

	// Use this for initialization
    private bool isOn;
	void Start ()
	{
	    isOn = false;
	transform.eulerAngles=new Vector3(0,0,30);
	}
	
	// Update is called once per frame
	void Update () {
        //关闭开关 off
	    if (Input.GetKeyDown(KeyCode.G))
	    {
	        isOn = false;
	    }
        //打开按钮
	   
	    if (Input.GetKeyDown(KeyCode.K))
	    {
	        isOn = true;
	    }

	    if (isOn == false)
	    {
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0, 0, 30), 3);
	    }
	    else
	    {
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0, 0, 0), 3);
	    }
	
	}
}
