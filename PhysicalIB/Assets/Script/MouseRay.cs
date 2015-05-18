using UnityEngine;
using System.Collections;

public class MouseRay : MonoBehaviour {

    public static bool IsNull;      //判断是否点击在所需的物体上
    
	// Use this for initialization
	void Start () {
       
	
	}
	
	// Update is called once per frame
	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            print("hit.name="+hit.transform.name);
           
                IsNull = true;
                Debug.Log("NO NULL");         
        }
        else
        {
            IsNull = false;
            Debug.Log("isNull");
        }
	}
}
