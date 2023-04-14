using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Control : MonoBehaviour 
{
    // ��ũ��Ʈ�� ��Ȱ��ȭ�� ���·� ���� ������Ʈ�� �����Ǿ��� ��
    // �� �ѹ��� ȣ���ϴ� �̺�Ʈ �Լ��Դϴ�.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // ��ũ��Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // ��ũ��Ʈ�� Ȱ��ȭ�� ���·� ���� ������Ʈ�� �����Ǿ��ٸ�
    // �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    void Start()
    {
        Debug.Log("Start");
    }

    // �����Ӱ� ������� ������ �ð� ����(TimeStep 0.02��)
    // ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� �� �����Ӹ���
    // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    void Update()
    {
        // GetKeyDown : Ű�� �������� ȣ��Ǵ� �Լ�
        // GetKey : Ű�� ������ ������ ȣ��Ǵ� �Լ�
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

    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� Update() �Լ���
    // ȣ��ǰ� ���� �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // ������ ����Ǿ��� �� �� �ѹ��� ȣ��Ǵ�
    // �̺�Ʈ �Լ��Դϴ�.
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ�
    // �̺�Ʈ �Լ��Դϴ�.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // ���� ������Ʈ�� Ȱ��ȭ�� ���·� ���� ������Ʈ��
    // �ı��Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
