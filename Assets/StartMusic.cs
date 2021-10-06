using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public FMOD.Studio.EventInstance music;
    
    void Start()
    {
        music = FMODUnity.RuntimeManager.CreateInstance("event:/MUSIC/music");
        music.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
