using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttemptCounter : MonoBehaviour
{
   public Transform player;
   public TextMeshProUGUI scoreText;
   public float OffsetScore;
    void Update()
    {
        float finalScore = player.position.z + OffsetScore;
        scoreText.text = finalScore.ToString("0");
        
    }
}

