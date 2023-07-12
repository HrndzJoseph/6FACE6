using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text ScoreTxt;

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = player.position.z.ToString("0");

    }
}
