using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Collider))]
public class Pickup : MonoBehaviour
{
    public virtual void Drop()
    {
        StartCoroutine(DoDrop());
    }
    IEnumerator DoDrop()
    {
        transform.SetParent(null);
        yield return new WaitForSeconds(1); //To give the user a chance to move away before it's enabled again
        GetComponent<Collider2D>().enabled = true;
    }
    void OnTriggerEnter(Collider collision) //When entering the beam
    {
        print("Picking Up Object");
        if (collision.tag == "Player")
        {
            print("Picking Up Object");
            transform.parent = collision.transform;
        }
    }
}