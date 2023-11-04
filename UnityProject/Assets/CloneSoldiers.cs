using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Mathf;

public class CloneSoldiers : MonoBehaviour
{

    public GameObject soldierToClone;

    public int numberOfClones = 100;

    public float xrange = 100.0f;
    public float zrange = 100.0f;
    

    public void Clone()
    {
        Debug.Log("Clone Called: "+soldierToClone.transform.position);

        GameObject root  = GameObject.Find("Root");

        for (int i=0; i<numberOfClones ; i++)
        {
            GameObject go = Instantiate( soldierToClone ,root.transform);

            go.transform.position = new Vector3(
                    soldierToClone.transform.position.x+(UnityEngine.Random.value - 0.5f)*xrange, 
                    soldierToClone.transform.position.y,
                    soldierToClone.transform.position.z+(UnityEngine.Random.value - 0.5f)*zrange 
                    );
            go.transform.eulerAngles = new Vector3(
                soldierToClone.transform.eulerAngles.x, 
                soldierToClone.transform.eulerAngles.y + (UnityEngine.Random.value - 0.5f)*360.0f,
                soldierToClone.transform.eulerAngles.z
                );         

        }

        // instanitate.
        return;
    } 
}
