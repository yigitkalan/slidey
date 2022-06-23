using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text textScores;

    // Update is called once per frame
    void Update()
    {
        textScores.text = ((int)player.position.z).ToString();
    }
}
