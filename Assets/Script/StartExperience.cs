using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class StartExperience : MonoBehaviour
{
    [SerializeField] private GameObject cube;

    public void OnStartExperience(ARPlane plane)
    {
        if (cube == null)
        {
            Debug.LogError("Cube não foi atribuído no Inspector!");
            return;
        }

        if (plane == null)
        {
            Debug.LogError("ARPlane é NULL. Nenhum plano válido encontrado.");
            return;
        }

        Instantiate(cube, plane.transform.position, Quaternion.identity);
    }
}
