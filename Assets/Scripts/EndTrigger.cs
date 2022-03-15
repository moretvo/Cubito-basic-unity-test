using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

        public AudioSource endLevelSound;
        public GameManager gameManager;
        void OnTriggerEnter ()
        {
            endLevelSound.Play();
            gameManager.CompleteLevel();
        }

}

