using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Followers : MonoBehaviour
{
    public Transform target;
    private Quaternion curRotaton;

    public GameManager gm;

    
    // Start is called before the first frame update
    void Start()// dijalankan sekali pas play
    {
        curRotaton = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.isGameOver) return;
        
        transform.position = Vector3.Lerp(transform.position, target.position, 100.0f * Time.fixedDeltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, curRotaton, 0.500f);

        if (Input.GetKey(KeyCode.LeftArrow))// rotate target
        {
            curRotaton *= Quaternion.Euler(0, -4, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            curRotaton *= Quaternion.Euler(0, 4, 0);
        }
    }
}
