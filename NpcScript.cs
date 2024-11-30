using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    // НПС хп
    public int health = 5;

    //Уровень нпс
    public int Level = 1;

    //Скорость нпс
    public float Speed = 1.3f;


    void Start()
    {
        health = Level + health;
        print("Хп" + health);
    }

    //Двигается
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += Speed * Time.deltaTime;
        transform.position = newPosition;
    }




}
