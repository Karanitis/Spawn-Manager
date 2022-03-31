using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    private PlayerController playerScript;
    private float starDelay = 2;
    private float repeatRate = 2.5f;
    [SerializeField] GameObject engel;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnEngel", starDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEngel()
    {
        if (playerScript.gameOver == false)
        {
            Instantiate(engel, spawnPos, engel.transform.rotation);
        }
      
    }

    public void Restart()
    {
        SceneManager.LoadScene("karanitis");
    }

}
