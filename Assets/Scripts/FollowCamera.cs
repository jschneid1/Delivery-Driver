using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //This things ('camera') position, should be the same as the car

    [SerializeField] private GameObject _thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _thingToFollow.transform.position + new Vector3(0f, 0f, -10f);
    }
}
