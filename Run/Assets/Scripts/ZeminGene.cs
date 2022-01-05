using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGene : MonoBehaviour
{

    public GameObject zemin;
    public Transform trbelirleme;

    public int zeminsayisi;

    public float zemingenislik;

    public float miny, maxy;

    void Start()
    {
        trbelirleme = zemin.GetComponent<Transform>();

        Vector3 spawnLoc = new Vector3();
        Vector2 scaledeger = new Vector2();

        for (int i = 0; i < zeminsayisi; i++)
        {

            //scale atadýk
            scaledeger.x = Random.Range(0.9f,1.1f);
            scaledeger.y = Random.Range(0.43f, 1.06f);
            trbelirleme.localScale = scaledeger;
            //nerede spawnlanack belirledik x ve y olarak
            spawnLoc.y += Random.Range(miny,maxy);
            spawnLoc.x = Random.Range(-zemingenislik, zemingenislik);

            //cogaltýyoruz Instantiate ile
            Instantiate(zemin,spawnLoc,Quaternion.identity);

        }

    }



}
