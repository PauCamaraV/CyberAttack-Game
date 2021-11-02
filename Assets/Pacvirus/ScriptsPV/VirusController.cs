using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController : MonoBehaviour{
    [SerializeField]
    private Transform[] posisiPOINT;

    [SerializeField]
    private float kec = 3f;
    private int indexPoint = 0;

    private void Start(){
        transform.position = posisiPOINT[indexPoint].transform.position;
    }

    private void Update(){
        Move();
    }

    void Move(){
        transform.position = Vector2.MoveTowards(transform.position, posisiPOINT[indexPoint].transform.position, kec * Time.deltaTime);
        if(transform.position == posisiPOINT[indexPoint].transform.position){
            indexPoint += 1;
        }
        if(indexPoint == posisiPOINT.Length){
            indexPoint = 0;
        }
    }


}
