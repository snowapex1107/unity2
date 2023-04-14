using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public int data = 100;

    private void Start()
    {
        Debug.Log("Data : " + data);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }

    // �������� �浹�� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    // �������� �浹�� ���� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    // �������� �浹�� ������ �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
}
