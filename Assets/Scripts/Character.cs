using System;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int atk;

    public void Attack(Enemy enemy)
    {
        // enemy.hp = enemy.hp - atk;
        enemy.TakeDamage(atk);
    }

    public void SetAtk(int atkValue)
    {
        atk = atkValue;
    }

    [SerializeField]
    private List<Enemy> enemies = new List<Enemy>();

    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        var enemy = collider2D.GetComponent<Enemy>();
        enemies.Add(enemy);
    }

    [ContextMenu("角色攻擊偵測到的所有敵人")]
    public void AttackAllTriggeredEnemies()
    {
        foreach (var enemy in enemies)
        {
            enemy.TakeDamage(atk);
        }
    }
}