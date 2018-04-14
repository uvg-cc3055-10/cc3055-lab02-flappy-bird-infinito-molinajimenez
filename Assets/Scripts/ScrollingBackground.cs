using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
    public float scrollingSpeed = 5f;
    public GameObject fondo;
        
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.isFinished == false)
        {
            fondo.transform.Translate(new Vector3(-1, 0, 0) * scrollingSpeed * Time.deltaTime);
            if (fondo.transform.position.x < -20.4f)
            {
                fondo.transform.position = new Vector3(20.4f, fondo.transform.position.y, fondo.transform.position.z);
            }
            
        }
        else
        {
            fondo.transform.Translate(new Vector3(0, 0, 0));

        }

    }

}
