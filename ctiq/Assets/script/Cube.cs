using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cube : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    
{
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        // 이동
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // 회전
        if (moveDirection.magnitude != 0) transform.rotation = Quaternion.LookRotation(moveDirection);
    }

}



