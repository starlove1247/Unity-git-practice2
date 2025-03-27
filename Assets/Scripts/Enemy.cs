using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;

    public void SetHp(int hpValue)
    {
        hp = hpValue;
    }

    public void TakeDamage(int damage)
    {
        // var newHp = hp - damage;
        // hp = newHp;
        if (hp > 0)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }

    public int GetHp()
    {
        return hp;
    }
}