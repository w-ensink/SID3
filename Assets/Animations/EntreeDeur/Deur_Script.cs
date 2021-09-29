using UnityEngine;

public class Deur_Script : MonoBehaviour
{
  //  [FMODUnity.EventRef]
  //  public string soundEvent;
  //  FMOD.Studio.EventInstance Ambience;

  //  [FMODUnity.EventRef]
  //  public string soundEvent2;
  //  FMOD.Studio.EventInstance Music;

    public GameObject trigger;
    public GameObject deur;

    Animator deurAnim;
    // Start is called before the first frame update
    void Start()
    {
        deurAnim = deur.GetComponent <Animator> ();

    }

    void OnTriggerEnter(Collider coll) {
      if(coll.gameObject.tag == "Player") {
        AutoDeur (true);
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Environment/Environment_deur_open", transform.position);
        //combat music parameter switch
        Debug.Log("cool");
      }
    }

    void OnTriggerExit(Collider coll) {
      if(coll.gameObject.tag == "Player") {
        AutoDeur (false);
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Environment/Environment_deur_open", transform.position);
      }
    }

    void AutoDeur(bool state) {
      deurAnim.SetBool ("slide", state);
    }
    // Update is called once per frame

}
