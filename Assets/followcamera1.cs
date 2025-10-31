using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        [SerializeField] GameObject thingToFollow;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}

