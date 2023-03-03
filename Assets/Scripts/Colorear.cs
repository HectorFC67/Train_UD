using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colorear : MonoBehaviour
{
    Object[] allTheGameObjects;

    Object[] allTheGameObjectsTag;


    [Serialize]
    public Color color;
    [Serialize]
    public string choosenTag;

    // Start is called before the first frame update
    Material material;
    


    void Start()
    {
        allTheGameObjects = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
 
    }

    // Update is called once per frame
    void Update()
    {
        allTheGameObjectsTag = GameObject.FindGameObjectsWithTag(choosenTag);
        foreach (var item in allTheGameObjectsTag)
        {
            if (item.GetComponent<MeshRenderer>())
            {
                item.GetComponent<MeshRenderer>().material.color = color;
            }
        }

        // Encontrar el nombre (superior derecha) del objeto y pintarlo
        /*GameObject objeto = GameObject.Find("CuboMovil");
        Renderer matComp = objeto.GetComponent<Renderer>();
        matComp.material.color = color;*/


        // Que se cambie el color del objeto si cambiamos la ruleta
        /*foreach(var item in allTheGameObjects)
        {
            if(item.GetComponent<MeshRenderer>()){
                item.GetComponent<MeshRenderer>().material.color = color;
            }
        }*/
    }
}
