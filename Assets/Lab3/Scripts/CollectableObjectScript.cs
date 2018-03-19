using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObjectScript : MonoBehaviour {

    public int objectKind;

    void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is a player, then do something
        if (!other.gameObject.isStatic)
        {
            other.GetComponent<PlayerController>().CollectObject(objectKind);
            Destroy(this.gameObject);
        }
    }
}
