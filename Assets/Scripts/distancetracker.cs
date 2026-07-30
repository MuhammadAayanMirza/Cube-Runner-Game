using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttemptCounter : MonoBehaviour
{
   public Transform player;
   public TextMeshProUGUI scoreText;
    void Update()
    {
        float offsetScore = player.position.z +21;
        scoreText.text = offsetScore.ToString("0");
        
    }
}

