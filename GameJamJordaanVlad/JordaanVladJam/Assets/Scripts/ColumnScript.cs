using UnityEngine;
using System.Collections;

public class ColumnScript : MonoBehaviour {

    void OnOnTriggerEnter(Collider other)
    {
        if (other.tag.Contains("Projectile"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.tag.Contains("Player"))
        {
            other.GetComponent<PlayerManager>().Crash();
        }
    }
}
