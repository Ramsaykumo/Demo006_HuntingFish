using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishArrt : MonoBehaviour {

    public int MaxNum;
    public int MaxSpeed;
    public int hp;
    public int exp;
    public int gold;

    public GameObject diePrefab;
    public GameObject goldPrefab;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Border")
        {
            Destroy(gameObject);
        }
    }

    void TakeDamage(int value)
    {
        hp -= value;
        if (hp <= 0)
        {
            GameController.Instance.gold += gold;
            GameController.Instance.exp += exp;
            GameObject die = Instantiate(diePrefab) as GameObject;
            die.transform.SetParent(gameObject.transform.parent, false);
            die.transform.position = transform.position;
            die.transform.rotation = transform.rotation;
            GameObject goldGo = Instantiate(goldPrefab) as GameObject;
            goldGo.transform.SetParent(gameObject.transform.parent, false);
            goldGo.transform.position = transform.position;
            goldGo.transform.rotation = transform.rotation;
            if (gameObject.GetComponent<Ef_PlayEffect>() != null)
            {
                gameObject.GetComponent<Ef_PlayEffect>().PlayEffect();
            }
            Destroy(gameObject);
        }
    }

}
