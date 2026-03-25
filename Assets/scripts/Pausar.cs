using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausar : MonoBehaviour
{
    public GameObject Conteiner;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Conteiner.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Resumo()
    {
        Conteiner.SetActive(false);
        Time.timeScale = 1;
    }
    public void Sair()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
