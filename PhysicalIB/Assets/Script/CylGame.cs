using UnityEngine;
using System.Collections;

public class CylGame : MonoBehaviour {
    
    Vector2 size;
    private float offset_f = 0;
	// Use this for initialization
	void Start () {

        size = new Vector2(1,transform.parent.localScale.x*2);
        //改变材质中Tiling的值
        transform.GetComponent<Renderer>().material.mainTextureScale = size;
	}

	
	// Update is called once per frame
	void Update ()
	{
	    offset_f += Time.deltaTime;
	    transform.GetComponent<Renderer>().material.mainTextureOffset=new Vector2(0,offset_f);      
	}


}
