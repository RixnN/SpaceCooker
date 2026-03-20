using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crumbs : MonoBehaviour
{
    public static Crumbs instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(instance);
            instance = this;
        }
    }
    [SerializeField] private Animator animator;
    public int stage = 0;

    public void TriggerFade()
    {
        stage++;
        animator.SetInteger("Stage", stage);
        if (stage == 3) Debug.Log("œ–Œ»√–€ÿ!");
    }
}
