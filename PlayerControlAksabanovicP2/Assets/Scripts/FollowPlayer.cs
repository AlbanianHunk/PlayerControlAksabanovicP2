using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject follow;
    public KeyCode Keys;
    bool buttondown = true;
    private Vector3 offset = new Vector3(-0, 5, -10);
    private Vector3 offset2 = new Vector3(0, 4, -2);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (Input.GetKeyDown(Keys))
        {
            if (buttondown)
            {
                buttondown = false;
            }
            else
            {
                buttondown = true;
            }
        }
        if (buttondown == true)
        {
            transform.position = follow.transform.position + offset;
        }
        if (buttondown == false)
        {
            transform.position = follow.transform.position + offset2;
        }
    }
}
