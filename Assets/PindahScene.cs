using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindahScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Digunakan untuk pindah scene yang berada pada assets/scene
    public void pindahScene(string namaScene)
    {
        Application.LoadLevel(namaScene);
    }
    public void KeluarApp()
    {
        Application.Quit();
    }
}
