using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCubes : MonoBehaviour
{
    bool isCollected = false; //daha önce bu küp toplandý mý diye kontrol ettiriyorum.
    int index; // toplama pozisyonu yüksekliði belirtecek

    private void Start()
    {
        isCollected = false; //baþlangýçta toplanmadýðý için false veriyorum
    }
    public bool GetIsCollected() //bool private olduðundan eriþmek için return döndürüyorum.
    {
        return isCollected;
    }
    public void DoCollected()
    {
        isCollected = true; //toplandýðý zaman deðer döndürmesi için true yapýyorum
    }
    public void ManageIndex(int index)
    { 
        this.index = index;  //globaldeki indexi bu indexe eþitliyorum 
    }
    private void Update()
    {
        if (isCollected == true)
        {
            if (transform.parent != null)  //toplandýysa ve parent'a sahipse
            {
                transform.localPosition = new Vector3(0, -index, 0); //topladýðýmýz küplerin pozisyonunu sabitliyorum
            }     
        }
        
    }
}
