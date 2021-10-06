using UnityEngine;
using System.Collections;
using FMOD.Studio;
public class TriggerLevelMusic : MonoBehaviour
{
    public float value;
    
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<StartMusic>().music.setParameterByName("room", value);
            Debug.Log("binnen");
        }
    }
}