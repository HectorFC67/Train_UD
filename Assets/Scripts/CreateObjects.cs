using Assets;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    int MaxEnemies = 5;
    Enemy[] listEnemyOfFive;

    private Player player;
    private List<Enemy> listEnemies = new List<Enemy>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= MaxEnemies; i++)
        {
            Enemy enemy = new Enemy($"Enemy {i}");
            listEnemyOfFive[i] = new Enemy("Enemigo" + i);
        }

        Enemy enemyClasic1 = new Enemy("Voldemort");
        Enemy enemyClasic2 = new Enemy("Bowser");
        Enemy enemyClasic3 = new Enemy("Giovanni");

        listEnemies.Add(enemyClasic1);
        listEnemies.Add(enemyClasic2);
        listEnemies.Add(enemyClasic3);

        player = new Player("Benito");
        
    }

    // Update is called once per frame
    void Update()
    {
        var enemy = listEnemies.First(e => e.Name == "Voldemort");
        Debug.Log("Encontrado!" + enemy);
    }
}
