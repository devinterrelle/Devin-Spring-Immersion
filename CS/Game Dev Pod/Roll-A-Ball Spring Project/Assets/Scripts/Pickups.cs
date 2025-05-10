using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    private bool isCollected = false;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime);
    }

  private void OnTriggerEnter(Collider other) 
    {
        if (isCollected == true )
        {
            return; 
        }
        if (other.gameObject.CompareTag("Player"));
        {
isCollected = true; 
    Destroy(this.gameObject);
    GameManager.Instance.UpdateScore(1);

    AudioManager.Instance.PlaySound("Collect Coin");
        }
    }

}
