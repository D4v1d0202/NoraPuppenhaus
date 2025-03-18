using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SprechblasenManager : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject sprechblase;
    public InputActionProperty showButton;
    private bool isTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame() || isTriggered)
        {
            sprechblase.SetActive(!sprechblase.activeSelf);

            sprechblase.transform.position = head.position + new Vector3(head.forward.x,0,head.forward.z).normalized * spawnDistance;
        }
        isTriggered = false;

        sprechblase.transform.LookAt(new Vector3 (head.position.x, sprechblase.transform.position.y, head.position.z));
        sprechblase.transform.forward *= -1;
    }

    public void SetTrigger()
    {
        isTriggered = true;
    }

}
