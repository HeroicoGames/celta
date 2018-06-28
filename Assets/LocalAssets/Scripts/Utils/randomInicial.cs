using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomInicial : MonoBehaviour {

    public Transform[] instanciadores;
    public GameObject[] Herramientas;
    public bool[] ready;
    public int n;

	void Start () {
        for (int i= 0; i<=Herramientas.Length-1;i++) {
            n = Random.Range(0, Herramientas.Length-1);
            if (ready[n]) {
                cambiar();
            }
            GameObject Herramienta = Instantiate(Herramientas[i], instanciadores[n]);
            position(Herramienta);
            ready[n] = true;
        }
	}

    void position(GameObject h) {
        h.GetComponent<Transform>().localPosition = new Vector3(0,0,0);
    }

    void cambiar() {
        bool volver = true;
        while (volver)
        {
            n++;
            if (n > Herramientas.Length - 1)
            {
                n = 0;
            }
            volver = ready[n];
        }
    }
}
