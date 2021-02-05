using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideInfo : MonoBehaviour
{
    public GameObject InfoObject;
    private bool Show = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //menampikan Info
    public void ShowAndHideInfo()
    {
        if(!Show){
            InfoObject.SetActive(true);
            Show=true;
        }
        else {
            InfoObject.SetActive(false);
            Show=false;
        }
    }
    public void tutupG() //fungsi tutup gameobject
    {
        InfoObject.SetActive(false); //tutup gameobject
    }
    public void bukaO() //buka tutup gameobject
    {
        InfoObject.SetActive(true); //tutup gameobject
    }
}
