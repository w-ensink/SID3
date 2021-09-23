using UnityEngine;

public class Trigger1Script : MonoBehaviour
{

    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider coll) {
      if(coll.gameObject.tag == "Player") {
        //combat music parameter switch
        Debug.Log("cool");
      }
    }


}
