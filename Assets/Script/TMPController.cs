using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TMPController : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public Transform player;

     void Update()
    {
        myText.text = player.position.z.ToString("0");
    }
}