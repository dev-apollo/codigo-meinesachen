using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private bool aberto = false;
    public GameObject menuUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(aberto){
                Fechar();
            }else{
                Abrir();
            }
        }
    }
    void Fechar(){
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        aberto = false;
    }
    void Abrir(){
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        aberto = true;
    }
}