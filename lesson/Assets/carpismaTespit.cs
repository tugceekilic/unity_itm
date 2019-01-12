using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpismaTespit : MonoBehaviour
{
    public int puan;
    private List<GameObject> puanObjeleri = new List<GameObject>();

    private void OnCollisionEnter (Collision collision)
    {   
        puanObjeleri.Add(GameObject.Find("PositiveObject")); // 3+ 2- olacak
        puanObjeleri.Add(GameObject.Find("PositiveObject"));
        puanObjeleri.Add(GameObject.Find("PositiveObject"));
        puanObjeleri.Add(GameObject.Find("NegativeObject"));
        puanObjeleri.Add(GameObject.Find("NegativeObject"));
        int secimDegiskeni = Random.Range(0, 5);
        float rastgeleXDegiskeni = Random.Range(-4.91f, 0.92f);
        float rastgeleZDegiskeni = Random.Range(5.79f, 0.92f);
        GameObject yaratilanObje = (GameObject)Instantiate(puanObjeleri[secimDegiskeni], new Vector3(rastgeleXDegiskeni. 4f, rastgeleZDegiskeni), Quaternion.Euler(0, 0, 0));
    }


    // Update is called once per frame
    void Update()
    {
       transform.rotate(1,3,4) 
    }
}
