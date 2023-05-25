using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARROW : MonoBehaviour
{
  private void Start()
{
Destroy(gameObject, 7);
}

private void OnTriggerEnter(Collider other)
{
Destroy(transform.GetComponent<Rigidbody>());
}

}
