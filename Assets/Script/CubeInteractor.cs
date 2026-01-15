using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CubeInteractor : MonoBehaviour, Interactable
{
    public void OnInteract()
    {
        Debug.Log("Interagindo com o cubo");
    }
    public void StopInteract()
    {
        Debug.Log("Parei de interagir com o cubo");
    }

    // Update is called once per frame
    void Update()
    {
        if(InputHandler.TryRayCastHit(out RaycastHit hitObject))
        {
            if (hitObject.transform == transform)
            {
                OnInteract();
            }
        }
    }
}
