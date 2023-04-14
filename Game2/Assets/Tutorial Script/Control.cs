using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Control : MonoBehaviour 
{
    // 스크립트가 비활성화된 상태로 게임 오브젝트가 생성되었을 때
    // 단 한번만 호출하는 이벤트 함수입니다.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // 스크립트가 활성화되었을 때 호출되는 이벤트 함수입니다.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // 스크립트가 활성화된 상태로 게임 오브젝트가 생성되었다면
    // 단 한 번만 호출되는 이벤트 함수입니다.
    void Start()
    {
        Debug.Log("Start");
    }

    // 프레임과 상관없이 무조건 시간 기준(TimeStep 0.02초)
    // 으로 호출되는 이벤트 함수입니다.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // 게임 오브젝트가 활성화된 상태로 매 프레임마다
    // 호출되는 이벤트 함수입니다.
    void Update()
    {
        // GetKeyDown : 키를 눌렀을때 호출되는 함수
        // GetKey : 키를 누르고 있을때 호출되는 함수
        if(Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + Vector3.forward * 5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left * 5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Vector3.back * 5f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right * 5f * Time.deltaTime;
        }
        Debug.Log("Update");
    }

    // 게임 오브젝트가 활성화된 상태로 Update() 함수가
    // 호출되고 나서 마지막에 호출되는 이벤트 함수입니다.
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // 게임이 종료되었을 때 단 한번만 호출되는
    // 이벤트 함수입니다.
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    // 게임 오브젝트가 비활성화되었을 때 호출되는
    // 이벤트 함수입니다.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // 게임 오브젝트가 활성화된 상태로 게임 오브젝트가
    // 파괴되었을 때 호출되는 이벤트 함수입니다.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
