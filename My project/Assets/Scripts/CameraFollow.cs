using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target; //kameranýn takip edeceði hedef için deðiþken
    public Vector3 distance; // ve takip mesafesi için bir deðiþken 

    private void LateUpdate() //kamera fonksiyonlarý late update'de kullanýlýyor
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + distance, Time.deltaTime); // .lerp ile kameranýn smooth bir þekilde takip etmesini saðladým

    }
}
