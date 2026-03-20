using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class CutBox : MonoBehaviour
{
    public bool isLidHere = false;

    ParticleSystem crumbs;
    AudioSource cuting;
    [Header("Food Prefabs")]
    [SerializeField] GameObject cutedBreadPref;
    [SerializeField] GameObject cutedApplePref;
    [SerializeField] GameObject cutedCheesePref;
    private void OnTriggerStay(Collider other)
    {
        string objTag = other.tag;
        if (isLidHere )
        {
            switch (objTag)
            {
                case "bread":
                    cuting.Play();
                    Destroy(other.gameObject);
                    Instantiate(cutedBreadPref, other.transform.position, other.transform.rotation);
                    Instantiate(cutedBreadPref, other.transform.position, other.transform.rotation);
                    break;
                case "cheese":
                    cuting.Play();
                    Destroy(other.gameObject);
                    Instantiate(cutedCheesePref, other.transform.position, other.transform.rotation);
                    Instantiate(cutedCheesePref, other.transform.position, other.transform.rotation);
                    break;
                case "apple":
                    cuting.Play();
                    Destroy(other.gameObject);
                    Instantiate(cutedApplePref, other.transform.position, other.transform.rotation);
                    Instantiate(cutedApplePref, other.transform.position, other.transform.rotation);
                    break;
            }
        }
        else
        {
            crumbs.Play();
            Crumbs.instance.TriggerFade();
        }

    }
   
}
