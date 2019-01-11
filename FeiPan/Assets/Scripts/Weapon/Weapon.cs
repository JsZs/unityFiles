using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    private Transform m_transform;

    private Ray ray;
    private RaycastHit hit;
    
     private Transform m_point;
     private LineRenderer m_LineRenderer;
    void Start () {
        m_transform = gameObject.GetComponent<Transform >();
        m_point = m_transform.Find("Point");
        m_LineRenderer =m_point.gameObject.GetComponent<LineRenderer >();//父类引用才能用Get Component
	}
	
	void Update () {
        turnTO();
	}

    void turnTO()
    {
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input .mousePosition );
            if (Physics.Raycast(ray, out hit))
            {
                m_transform.LookAt(hit.point);//控制手朝向射线碰撞点
                
             Debug.DrawLine(m_point.position, hit.point, Color.red);//绘制测试线
               
                

             m_LineRenderer.SetPosition(0,m_point.position );//设置测试线位置
                m_LineRenderer.SetPosition(1, hit .point);
                //飞盘射击
                if (hit.collider .tag =="FeiPan")
                {


                }
            
}

        }

    }
}
