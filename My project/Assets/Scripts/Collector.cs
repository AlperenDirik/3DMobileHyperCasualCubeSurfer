using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    int height; //k�pleri toplad�k�a boyumuz y�kselece�i i�in y�kseklik tan�ml�yorum
    private void Start()
    {
        mainCube = GameObject.Find("AnaKup"); // ana k�p ula��m� 
    }
    private void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z); //ald���m�z k�b�n yerden 1 birim y�kselmesini sa�lad�m
        this.transform.localPosition = new Vector3(0, -height, 0);//art�k her toplad���m k�pten sonra toplay�c� k�p bir altta kalacak ve toplamaya devam edecek.    
    }
    private void OnTriggerEnter(Collider other) // daha �nce trigger olarak ayarlad���m collector ve toplanabilirler i�in fonksiyonum haz�r
    {
        if (other.gameObject.tag == "Collectibles")
        {
            height += 1;
            other.gameObject.GetComponent<CollectibleCubes>().DoCollected(); //di�er scriptimdeki topland� olarak i�aretleyen fonksiyonumu �a��r�yorum
            other.gameObject.GetComponent<CollectibleCubes>().ManageIndex(height); //ayn� i�lem indexi e�itletiyorum
            other.gameObject.transform.parent = mainCube.transform; //art�k �arpt���m�z k�p toplanabilirse ana k�b�n alt�nda yer alacak

        }
    }
}
