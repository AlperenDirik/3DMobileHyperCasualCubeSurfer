using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target; //kameran�n takip edece�i hedef i�in de�i�ken
    public Vector3 distance; // ve takip mesafesi i�in bir de�i�ken 

    private void LateUpdate() //kamera fonksiyonlar� late update'de kullan�l�yor
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + distance, Time.deltaTime); // .lerp ile kameran�n smooth bir �ekilde takip etmesini sa�lad�m

    }
}
