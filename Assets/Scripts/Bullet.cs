using UnityEngine;

public class Bullet : MonoBehaviour
{
    int count = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Capsule")) gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            count++;
            gameObject.SetActive(false);
        }
        if(count==3){
            Destroy(collision.gameObject);
        }
    }

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Enemy"))
    //     {
    //         count++;
    //     }
    //     if (count == 3)
    //     {
    //         Destroy(collision);
    //     }
    // }
}
