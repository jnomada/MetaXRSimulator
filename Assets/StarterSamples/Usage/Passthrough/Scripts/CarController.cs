using UnityEngine;
using Meta.XR.Samples;
using System;

// This ensures the GrabObject is always there
[RequireComponent(typeof(GrabObject))]
public class CarController : MonoBehaviour
{
    public AudioSource audioSource;
    public ParticleSystem particle;
    public OVRInput.Controller controllerHand = OVRInput.Controller.None;

    void Start()
    {
        if (!audioSource) audioSource = GetComponent<AudioSource>();
        
        GrabObject grabScript = GetComponent<GrabObject>();
        if (grabScript != null)
        {
            grabScript.GrabbedObjectDelegate += Grab;
            grabScript.ReleasedObjectDelegate += Release;
        }
    }

    public void Grab(OVRInput.Controller grabHand)
    {
        Debug.Log("Car Grabbed by: " + grabHand);
        controllerHand = grabHand;
        if (audioSource) audioSource.Play();
        if (particle) particle.Play();
    }

    public void Release()
    {
        Debug.Log("Car Released");
        controllerHand = OVRInput.Controller.None;
        if (audioSource) audioSource.Stop();
        if (particle) particle.Stop();
    }
}