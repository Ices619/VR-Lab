using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;
    [SerializeField] GameObject key;
    private bool locked;
    // Start is called before the first frame update
    void Start()
    {
        locked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key" &&  locked)
        {
            if (other.gameObject.name == key.gameObject.name)
            {
                UnlockDoor();
            }
        
        }
        
    }

    private void UnlockDoor()
    {
        door.GetComponent<Rigidbody>().isKinematic = false;
        handle.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<BoxCollider>().isTrigger = false;
        locked = false;
    }
}
