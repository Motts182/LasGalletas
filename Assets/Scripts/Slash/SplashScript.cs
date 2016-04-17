using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class SplashScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(AnimationSplash());
        print("Start");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator AnimationSplash(){
        print("Animation");

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Muro");

        print("End");

    }

}
