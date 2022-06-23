using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter()
    {
        gm.levelComplete();
    }
}
