using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class InitialSetUp : MonoBehaviour
{
    [SerializeField] private float requiredArea;

    [SerializeField] private ARPlaneManager planeManager;

    [SerializeField] private GameObject startExperienceUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnabled()
    {
        planeManager.planesChanged += OnPlanesUpdated;
    }

    void OnDisabled()
    {
        planeManager.planesChanged -= OnPlanesUpdated;
    }

    public void OnClickStartExperience()
    {
        Debug.Log("Iniciando a experiencia em AR...");
        startExperienceUI.SetActive(false);
        planeManager.enabled = false;

        foreach (var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }
    }

    public void OnPlanesUpdated(ARPlanesChangedEventArgs args){

        foreach (var plane in args.updated)
        {
            if (plane.extents.x * plane.extents.y >= requiredArea) {

                startExperienceUI.SetActive(true);
                
                
            }
        }
        
        } 
    }
