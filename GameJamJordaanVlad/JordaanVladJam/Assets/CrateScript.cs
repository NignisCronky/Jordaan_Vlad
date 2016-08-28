using UnityEngine;
using System.Collections;

public class CrateScript : MonoBehaviour {
    void OnOnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Projectile"))
        {
            gameObject.SetActive(false);
        }
    }
}
