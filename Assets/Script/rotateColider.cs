using UnityEngine;
using System.Collections;

public class rotateColider : MonoBehaviour {

    void Start() {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player" && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("1111");
            Quaternion rot = other.transform.rotation;
            rot.x = -180f;
            other.transform.rotation = rot;
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y - 1f, other.transform.position.z);
        }
    }
}
