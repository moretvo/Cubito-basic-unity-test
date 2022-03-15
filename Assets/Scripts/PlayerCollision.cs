using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    public AudioSource Sonido;
    
    void OnCollisionEnter(Collision collisionInfo){

        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }

        if(collisionInfo.collider.name == "ParedIzq")
        {
            Sonido.Play();
            Debug.Log("Toque pared izquierda, reboto");
            movement.rb.AddForce(500, 0, 200);
        }
        if(collisionInfo.collider.name == "ParedDer")
        {
            Sonido.Play();
            Debug.Log("Toque pared derecha, reboto");
            movement.rb.AddForce(-500, 0, 200);
        }
    }
}
