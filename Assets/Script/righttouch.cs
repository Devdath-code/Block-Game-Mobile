using UnityEngine;

public class righttouch : MonoBehaviour
{
    public playermovement player;
    public float sidewardForce = 500f;

    public void rightTouch()
    {
        player.GetComponent<Rigidbody>().AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}