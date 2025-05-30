using UnityEngine;
using TMPro;

public class CounterManager : MonoBehaviour
{
    public TextMeshProUGUI bulletCounterText;
    public TextMeshProUGUI enemyCounterText;

    public string bulletTag = "Bullet";
    public string enemyTag = "Enemy";

    void Update()
    {
        int bulletCount = GameObject.FindGameObjectsWithTag(bulletTag).Length;
        int enemyCount = GameObject.FindGameObjectsWithTag(enemyTag).Length;

        bulletCounterText.text = "Bullets: " + bulletCount;
        enemyCounterText.text = "Enemies: " + enemyCount;
    }
}