using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{
    public GameObject ghostcat;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Yes");
        ghostcat.SetActive(true);
    }
}
