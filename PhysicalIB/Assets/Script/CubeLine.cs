using System;
using UnityEngine;
using System.Collections;

public class CubeLine : MonoBehaviour
{

    public GameObject line;
    private Transform[] wayPoint=new Transform[2];
    
    int i;
    int m;
    void Start()
    {
        i = 0;
        m = 0;
    }
    void Update()
    {
   
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("ss=" + hit.transform.name);
            try
            {
                if (Input.GetMouseButtonDown(0))
                {
                    i = 0;
                    wayPoint[0] = hit.transform;
                    Debug.Log("0");
                }
                else  if (Input.GetMouseButtonUp(0) )
                {
                    wayPoint[1] = hit.transform;
                    Debug.Log("1");

                    if (i < wayPoint.Length - 1 && hit.transform.name != "Cylinder"&&(wayPoint[0]!=null&&wayPoint[1]!=null))
                    {
                       
                        if (GameObject.Find(wayPoint[i].name + wayPoint[i + 1].name) == null && GameObject.Find(wayPoint[i + 1].name + wayPoint[i].name) == null)
                        {
                            Vector3 tempPos = (wayPoint[i].position + wayPoint[i + 1].position) / 2;//计算两个点的中点坐标，
                            GameObject go = (GameObject)Instantiate(line, tempPos, Quaternion.identity);//在两个点的中点处实例化线条，因为对物体的缩放，是从中心向两边延伸
                            go.name = "" + wayPoint[i].name + wayPoint[i + 1].name;
                            go.transform.right = (go.transform.position - wayPoint[i].position).normalized;//改变线条的朝向
                            float distance = Vector3.Distance(wayPoint[i].position, wayPoint[i + 1].position);//计算两点的距离
                            go.transform.localScale = new Vector3(distance, 0.4f, 0.4f);//延长线条，连接两点。
                            i++;
                        }

                    }
                }
            }
            catch (Exception)
            {
                Debug.Log("错误");
                throw;
            }
          
            
        }
       
    }
}