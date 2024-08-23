using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public RedBird BirdScript;
    public GameObject Kolonlar;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    public IEnumerator SpawnObject()
    {
        while (!BirdScript.isDead)
        {
            Instantiate(Kolonlar, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);

           
        }
    }
}
