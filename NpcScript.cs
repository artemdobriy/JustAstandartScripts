using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    // ��� ��
    public int health = 5;

    //������� ���
    public int Level = 1;

    //�������� ���
    public float Speed = 1.3f;


    void Start()
    {
        health = Level + health;
        print("��" + health);
    }

    //���������
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += Speed * Time.deltaTime;
        transform.position = newPosition;
    }




}
