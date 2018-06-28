using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    private float dist;
    private Vector3 V3pos, v3inicial;
    private Plane plane;
    bool ok = false, presed = false,presionado= false;
    public float z;

    string tag;

    void Start()
    {
        v3inicial = transform.position;
        tag = this.gameObject.tag;
    }

    void OnMouseDown()
    {
        presionado = true;
        Vector3 x = Input.mousePosition;
        x.z = 2.6f;
        this.transform.position = Camera.main.ScreenToWorldPoint(x);
        plane.SetNormalAndPosition(Camera.main.transform.forward, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        plane.Raycast(ray, out dist);
        V3pos = transform.position - ray.GetPoint(dist);
    }

    private void OnMouseUp()
    {
        //presed = false;
        presionado = false;
        if (!ok && !presed) {
            transform.position = v3inicial;
        }
    }

    void resetpos() {
        transform.position = v3inicial;
    }

    void OnMouseDrag()
    {
        if (presionado) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float dist;
            plane.Raycast(ray, out dist);
            Vector3 v3Pos = ray.GetPoint(dist);
            transform.position = v3Pos + V3pos;
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        Shaders script = other.GetComponent<Shaders>();
        if (script != null) {
            presed = true;
        }
        if (other.CompareTag(tag))
        {
			GameObject.Find ("Sucess").GetComponentInChildren <AudioSource> ().Play ();
			GameObject.Find ("Estructura").GetComponent <Celta> ().points += 1;
            presionado = false;
            ok = true;
        }
        else {
			GameObject.Find ("Failure").GetComponentInChildren <AudioSource> ().Play ();
            presionado = false;
            StartCoroutine(cambiopos());            
        }
        if (script != null) {
            other.GetComponent<Shaders>().cambioShader(this.gameObject, ok);
        }        
    }

    IEnumerator cambiopos() {
        presed = false;
        resetpos();
        yield return new WaitForSeconds(0.5f);
        
    }
}