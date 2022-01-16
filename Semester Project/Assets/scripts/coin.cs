using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<player>().coinCount+=1;
        collider.gameObject.GetComponent<player>().ring();
        Destroy(gameObject);
    }
}
