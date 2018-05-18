using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {

    public Transform pointPrefab;

    private void Awake()
    {
        //shows at the prefab's default point
        //Instantiate(pointPrefab);

        ////store the point od the prefab
        //Transform point = Instantiate(pointPrefab);
        ////assign the prefab to a vector variable
        //point.localPosition = Vector3.right;

        //int i = 0;
        //while (i++ < 10)
        //{
        //    Transform point = Instantiate(pointPrefab);
        //    point.localPosition = Vector3.right * i;

        //}

        for (int i=0; i<10; i++)
        {
            Transform point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right *(( i+0.5f)/5f-1f);
            //scale cubes in 2 units domain
            point.localScale = Vector3.one / 5f;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
