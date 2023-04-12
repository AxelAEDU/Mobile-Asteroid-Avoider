using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        Playerhealth playerHealth = other.GetComponent<Playerhealth>();

        if(playerHealth == null)
        {
            return;
        }

        playerHealth.Crash();
    }
}
