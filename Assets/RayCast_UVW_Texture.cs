using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast_UVW_Texture : MonoBehaviour {

    public Vector3 pos;

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;
        Debug.Log("pos is " + pos);

        Debug.DrawLine(Vector3.zero, new Vector3(5, 0, 0), Color.white, 2.5f);
        Debug.DrawLine(Vector3.zero, new Vector3(5, 3, 0), Color.red, 2.5f);
        //Debug.DrawRay(transform.position, forward, Color.green);
        Debug.DrawRay(Vector3.zero, new Vector3(5, 0, 0), Color.green);
        Debug.DrawRay(Vector3.zero, pos, Color.green);
        print("debug drawlines");

        RaycastHit hit = new RaycastHit();
        Ray ray = new Ray(new Vector3(0,0,-4), new Vector3(0, 0, 1));
        if (Physics.Raycast(ray, out hit))
        {
            print("hit");
            print(hit.textureCoord);
            //GetComponent<Renderer>().material.mainTexture = texture;
            //texture.SetPixel(x, y, color);
        }
    }
}
