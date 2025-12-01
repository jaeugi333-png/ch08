using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    
    float span = 1.0f;
    float delta = 0;

    int ratio = 2;

    // Update is called once per frame
    void Update()
    {

        delta += Time.deltaTime;
        if(delta > span)
        {
            GameObject go;
            delta = 0;

            int dice = Random.Range(0, 10);
            if (dice < ratio)
            {
                go = Instantiate(bombPrefab);
            }
            else
            {
                go = Instantiate(applePrefab);
            }

            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            go.transform.position = new Vector3(x, 4, z);
        }
    }
}
