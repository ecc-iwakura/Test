using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // �ړ���
        Vector3 moveVec = new(1, 0, 0);

        // ��������
        rigidbody.AddForce(moveVec);

        // ���W�ړ�
        transform.position += moveVec;
    }
}
