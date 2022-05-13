using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int x = 60;
    int y = 48;

    int result = 0;
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");
    }
    // Start is called before the first frame update
    void Start()
    {
       /* transform.position += new Vector3
            (
            transform.position.x,
            transform.position.y,
            transform.position.z+1
            );

        Debug.Log("안녕하세요? 오수민입니다.");*/
       for(int i=1; i<= x&& i<=y; i++)
        {
            if(x % i == 0 && y % i == 0)
            {
                result = i;
            }
        }
        Debug.Log(result);
    }
      
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);

        if(Input.GetKey(KeyCode.A))
        {  
            
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            
            transform.position += Vector3.back * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
           
            transform.position += Vector3.right * Time.deltaTime;
        }
    }
}
