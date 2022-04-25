using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movingForwardSpeed; //oyun i�inde ileri gitme h�z�n� ayarlayabilmek i�in serialize field olarak tan�ml�yorum
    [SerializeField] private float directionSpeed; // ayn� �ekilde sa�a sola gitme h�z�n� ekliyorum
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * directionSpeed * Time.deltaTime; // kullan�c�dan input al�p yatay eksende hareket mekani�i olu�turuyorum.
        this.transform.Translate(horizontalAxis, 0, movingForwardSpeed * Time.deltaTime); // art�k karakterimiz inputlar�m�zla sa�a sola hareket edecek

    }
}
