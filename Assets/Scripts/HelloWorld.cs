using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    Player player = new Player ("Benito Potter");
    Enemy enemy = new Enemy("Voldemort");
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello: "+ gameObject.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello: "+ gameObject.name);

       // Debug.Log("Ey como andamios");
       // Debug.LogWarning("La has liado pero tranquilo");
       // Debug.LogError("La has preparado gorda");
    }
}
