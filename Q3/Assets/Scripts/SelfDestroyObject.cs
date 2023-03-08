using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyObject : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StartDestroyTimer());
    }

    IEnumerator StartDestroyTimer()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
