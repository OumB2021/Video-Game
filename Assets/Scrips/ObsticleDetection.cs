using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleDetection : MonoBehaviour
{
    public Transform player;
    public Score score;
    //public ObsticleDetect ob;
    // Update is called once per frame
    void Update()
    {
        if ((int)player.position.z == (int)this.transform.position.z)
        {
            this.GetComponent<Renderer>().material.color = Color.red;
            score.GameScore++;
            this.enabled = false;
        }
    }
}
