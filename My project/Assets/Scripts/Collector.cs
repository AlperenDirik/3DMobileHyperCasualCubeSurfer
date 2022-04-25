using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    int height; //küpleri topladýkça boyumuz yükseleceði için yükseklik tanýmlýyorum
    private void Start()
    {
        mainCube = GameObject.Find("AnaKup"); // ana küp ulaþýmý 
    }
    private void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z); //aldýðýmýz kübün yerden 1 birim yükselmesini saðladým
        this.transform.localPosition = new Vector3(0, -height, 0);//artýk her topladýðým küpten sonra toplayýcý küp bir altta kalacak ve toplamaya devam edecek.    
    }
    private void OnTriggerEnter(Collider other) // daha önce trigger olarak ayarladýðým collector ve toplanabilirler için fonksiyonum hazýr
    {
        if (other.gameObject.tag == "Collectibles")
        {
            height += 1;
            other.gameObject.GetComponent<CollectibleCubes>().DoCollected(); //diðer scriptimdeki toplandý olarak iþaretleyen fonksiyonumu çaðýrýyorum
            other.gameObject.GetComponent<CollectibleCubes>().ManageIndex(height); //ayný iþlem indexi eþitletiyorum
            other.gameObject.transform.parent = mainCube.transform; //artýk çarptýðýmýz küp toplanabilirse ana kübün altýnda yer alacak

        }
    }
}
