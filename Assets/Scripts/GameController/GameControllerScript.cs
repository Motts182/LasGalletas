using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;



public class GameControllerScript : MonoBehaviour {

    public GameObject canvas;
    public GameObject[] btns;
    //crear Enums con todos los nombres de botones y referencias;

    void Awake() {
       DontDestroyOnLoad(transform.gameObject);
       btns = GameObject.FindGameObjectsWithTag("btn"); 
    }

    void Start() {

        StartCoroutine(Test());
    }

    IEnumerator Test() {

       yield return new WaitForSeconds(5f);

       GameObject footer =  GameObject.Find("Footer");
        
       footer.SetActive(false);
       
       yield return new WaitForSeconds(1f);

       footer.SetActive(true);

       BuscarBtn("MuroBtn");

       yield return new WaitForSeconds(1f);

       SceneManager.LoadScene("Mapa");
       DesActiveBtn("MuroBtn");

       yield return new WaitForSeconds(1f);

       ActiveBtn("MuroBtn");

    }

    //Busca Botones por nombre;
    void BuscarBtn(string btnName) {
        foreach (GameObject btn in btns) {
            if (btn.name == btnName) {
                print(btn.name);
            }
        }
    }

    //Desactivar Botonpor nombre;
    void DesActiveBtn(string btnName)
    {
        foreach (GameObject btn in btns)
        {
            if (btn.name == btnName)
            {
                print(btn.name);
                btn.SetActive(false);
            }
        }
    }

    //Activa Botonpor nombre;
    void ActiveBtn(string btnName)
    {
        foreach (GameObject btn in btns)
        {
            if (btn.name == btnName)
            {
                print(btn.name);
                btn.SetActive(true);
            }
        }
    }


}
