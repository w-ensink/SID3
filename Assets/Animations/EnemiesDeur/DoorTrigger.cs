using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Enemy1;
    [SerializeField] private GameObject Enemy2;
    [SerializeField] private GameObject Enemy3;
    [SerializeField] private GameObject Enemy4;
  //  [SerializeField] private GameObject Enemy5;
    //meer toevoegen is ezpz
    bool isOpened = false;
    private Animator animator;

    private void Awake(){
      animator = GetComponent<Animator>();
      animator.SetBool("Open1", false);
    }

    private void Update()
    {
      if (Enemy1 == null && Enemy2 == null && Enemy3 == null && Enemy4 == null && isOpened == false){
        Debug.Log("GitHubPushPullTest");
        isOpened = true;
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Environment/Environment_deur_open", transform.position);
        //deur oneshot fmod
        //combat music parameter switch naar 0
        animator.SetBool("Open1", true);
      }

    }
}
