using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {

    [Range(10,100)] public int resolution = 10;

    public Transform pointPrefab;

    public Transform[] points;

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
        float step = 2f / resolution;
       Vector3 scale=  Vector3.one * step;
        Vector3 position;
        position.z = 0f;
        points = new Transform[resolution];

        for (int i=0; i< resolution; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x * position.x * position.x;
            point.localPosition = position;
            //scale cubes in 2 units domain
            point.localScale = scale;
            point.SetParent(transform, false);
            points[i] = point;
        }
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + Time.time));
            point.localPosition = position;
        }
    }
}
