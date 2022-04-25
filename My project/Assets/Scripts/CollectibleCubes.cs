using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCubes : MonoBehaviour
{
    bool isCollected = false; //daha �nce bu k�p topland� m� diye kontrol ettiriyorum.
    int index; // toplama pozisyonu y�ksekli�i belirtecek

    private void Start()
    {
        isCollected = false; //ba�lang��ta toplanmad��� i�in false veriyorum
    }
    public bool GetIsCollected() //bool private oldu�undan eri�mek i�in return d�nd�r�yorum.
    {
        return isCollected;
    }
    public void DoCollected()
    {
        isCollected = true; //topland��� zaman de�er d�nd�rmesi i�in true yap�yorum
    }
    public void ManageIndex(int index)
    { 
        this.index = index;  //globaldeki indexi bu indexe e�itliyorum 
    }
    private void Update()
    {
        if (isCollected == true)
        {
            if (transform.parent != null)  //topland�ysa ve parent'a sahipse
            {
                transform.localPosition = new Vector3(0, -index, 0); //toplad���m�z k�plerin pozisyonunu sabitliyorum
            }     
        }
        
    }
}
