using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BossDeur : MonoBehaviour
{
    [SerializeField] private GameObject Enemy1;
    [SerializeField] private GameObject Enemy2;
    [SerializeField] private GameObject Enemy3;
    [SerializeField] private GameObject Enemy4;
  //  [SerializeField] private GameObject Enemy5;
    //meer toevoegen is ezpz
    bool isOpened2 = false;
    private Animator animator;

    private void Awake(){
      animator = GetComponent<Animator>();
      animator.SetBool("Open2", false);
    }

    private void Update()
    {
      if (Enemy1 == null && Enemy2 == null && Enemy3 == null && Enemy4 == null && isOpened2 == false){
        Debug.Log("GitHubPushPullTest");
        isOpened2 = true;
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Environment/Environment_deur_mega_open", transform.position);
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Environment/Environment_alarm", transform.position);
        //boss music parameter WAIT TIME
        //boss deur oneshot afspelen
        animator.SetBool("Open2", true);
      }

    }
}
