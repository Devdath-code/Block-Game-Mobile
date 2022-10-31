using UnityEngine;

public class lefttouch : MonoBehaviour
{
    public playermovement player;
    public float sidewardForce = 500f;

    public void leftTouch()
    {
        player.GetComponent<Rigidbody>().AddForce(sidewardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
    }
}