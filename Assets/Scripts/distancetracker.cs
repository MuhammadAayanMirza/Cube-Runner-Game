using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttemptCounter : MonoBehaviour
{
   public Transform player;
   public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        
    }
}

