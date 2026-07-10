using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour



    {
        
        public string LevelName;
        void OnTriggerEnter(Collider col)
        {
            if(col.CompareTag("Player"))
            {
                SceneManager.LoadScene(LevelName);
            }
        }

            
        }

        
