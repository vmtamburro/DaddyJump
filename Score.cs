using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    private void Update()
    {
        scoreText.text = player.position.y.ToString("0");
    }
}
