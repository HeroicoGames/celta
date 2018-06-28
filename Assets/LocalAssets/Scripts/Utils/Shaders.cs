using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shaders : MonoBehaviour {

    public Material[] cambios;
    public GameObject texto;

    // Use this for initialization
    void Start () {
        cambios[0] = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cambioShader(GameObject other, bool good)
    {
        if (good)
        {            
            GetComponent<Renderer>().material = cambios[1];
        }
        else {
            texto.GetComponent<CountDown>().timeLeft -= 5.0f;
			texto.GetComponent <Text> ().color = Color.red;
            GetComponent<Renderer>().material = cambios[2];
        }
       
        StartCoroutine(tempo(other, good));
    }

    IEnumerator tempo(GameObject other, bool good) {
        yield return new WaitForSeconds(0.5f);
        if (good) {
            Destroy(other);
        }        
		texto.GetComponent <Text> ().color = Color.white;
        GetComponent<Renderer>().material = cambios[0];
    }
}
