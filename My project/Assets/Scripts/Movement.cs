using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movingForwardSpeed; //oyun içinde ileri gitme hýzýný ayarlayabilmek için serialize field olarak tanýmlýyorum
    [SerializeField] private float directionSpeed; // ayný þekilde saða sola gitme hýzýný ekliyorum
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * directionSpeed * Time.deltaTime; // kullanýcýdan input alýp yatay eksende hareket mekaniði oluþturuyorum.
        this.transform.Translate(horizontalAxis, 0, movingForwardSpeed * Time.deltaTime); // artýk karakterimiz inputlarýmýzla saða sola hareket edecek

    }
}
